Imports System.Collections.Generic
Imports System.IO
Imports tracefore.client.logging

Public Class DLogSample_Object_SaveGzip
	Public Sub Sample()
		' Prepare content from object directly
		Dim objQuery As New Object()
		Dim objReply As New Object()

		' Prepare token and ID
		Dim token As String = Guid.NewGuid().ToString()
		Dim sessionId As String = "123456789"
		Dim seqnum As String = "1"

		' Dlog
		Dim log As New DLogManager()
		log.TargetFolder = "your/target/path"

		' Prepare path and service
		Dim servicename As String = "ServiceQuery"
		Dim path As String = log.FullPath(token, sessionId, seqnum, servicename)

		' Save Query
		DLogManager.SaveGzip(path, objQuery)

		' Prepare path and service
		servicename = "ServiceReply"
		path = log.FullPath(token, sessionId, seqnum, servicename)

		' Save Reply
		DLogManager.SaveGzip(path, objReply)
	End Sub
End Class

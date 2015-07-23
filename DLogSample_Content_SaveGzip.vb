Imports System.Collections.Generic
Imports System.IO
Imports tracefore.client.logging

Public Class DLogSample_Content_SaveGzip
	Public Sub Sample()
		' Prepare content
		Dim query As String = "<QueryXml>Sample Query</<QueryXml>"
		Dim reply As String = "<ReplyXml>Sample Reply</<ReplyXml>"

		' Prepare token and ID
		Dim token As String = Guid.NewGuid().ToString()
		Dim sessionId As String = "123456789"
		Dim seqnum As String = "1"

		' Dlog
		Dim log As New DLogManager()
		log.TargetFolder = "your/target/path"

		' Prepare path and service
		Dim servicename As String = DLogManager.GetServiceName(query)
		Dim path As String = log.FullPath(token, sessionId, seqnum, servicename)

		' Save Query
		DLogManager.SaveGzip(path, query)

		' Prepare path and service
		servicename = DLogManager.GetServiceName(reply)
		path = log.FullPath(token, sessionId, seqnum, servicename)

		' Save Reply
		DLogManager.SaveGzip(path, reply)
	End Sub
End Class
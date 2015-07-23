using System;
using System.Collections.Generic;
using System.IO;
using tracefore.client.logging;

public class DLogSample_Object_SaveGzip
{
	public void Sample()
	{
		// Prepare content from object directly
		object objQuery = new object();
		object objReply = new object();

		// Prepare token and ID
		string token = Guid.NewGuid().ToString();
		string sessionId = "123456789";
		string seqnum = "1";

		// Dlog
		DLogManager log = new DLogManager();
		log.TargetFolder = "your/target/path";

		// Prepare path and service
		string servicename = "ServiceQuery";
		string path = log.FullPath(token, sessionId, seqnum, servicename);

		// Save Query
		DLogManager.SaveGzip(path, objQuery);

		// Prepare path and service
		servicename = "ServiceReply";
		path = log.FullPath(token, sessionId, seqnum, servicename);

		// Save Reply
		DLogManager.SaveGzip(path, objReply);
	}
}

	// Prepare content
	string query = "<QueryXml>Sample Query</<QueryXml>";
	string reply = "<ReplyXml>Sample Reply</<ReplyXml>";

	// Prepare token and ID
	string token = Guid.NewGuid().ToString();
	string sessionId = "123456789";
	string seqnum = "1";

	// Dlog
	DLogManager log = new DLogManager();
	log.TargetFolder = "your/target/path";

	// Prepare path and service
	string servicename = DLogManager.GetServiceName(query);
	string path = log.FullPath(token, sessionId, seqnum, servicename);

	// Save Query
	DLogManager.SaveGzip(path, query);

	// Prepare path and service
	servicename = DLogManager.GetServiceName(reply);
	path = log.FullPath(token, sessionId, seqnum, servicename);

	// Save Reply
	DLogManager.SaveGzip(path, reply);
	
	
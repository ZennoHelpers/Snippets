Tuple<string, string, string, string>[] allMails = ZennoPoster.BulkMailDownload(
	login: project.Variables["email"].Value,
	pass: project.Variables["email_pass"].Value,
	protocol: ZennoLab.InterfacesLibrary.Enums.Email.EmailProtocol.IMAP,
	lastHours: 24 * 100,
	maxCount: 100, // default 100
	deleteMessages: false,
	proxyString: instance.GetProxy(), // прокси, либо null
	throwException: true
);

foreach (Tuple<string, string, string, string> tuple in allMails)
{
	List<string> tmp = new List<string>
	{
		tuple.Item1,
		tuple.Item2,
		tuple.Item3,
		tuple.Item4,
	};
	project.Tables["Test"].AddRow(tmp);
}
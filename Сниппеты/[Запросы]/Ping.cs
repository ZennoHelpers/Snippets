System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
string ip = project.Variables["IP"].Value; // IP - переменная проекта зенки

try
{
    System.Net.NetworkInformation.PingReply reply = pinger.Send(ip);
	return reply.RoundtripTime;
}
catch (System.Net.NetworkInformation.PingException)
{
	throw new Exception("Не удалось пропинговать " + ip); // по красной
    //project.SendErrorToLog("Не удалось пропинговать " + ip); // по зелёной
}
finally
{
    if (pinger != null) pinger.Dispose();
}
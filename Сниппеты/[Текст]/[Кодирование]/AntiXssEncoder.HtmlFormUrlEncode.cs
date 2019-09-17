// добавить в GAC System.Web

return System.Web.Security.AntiXss.AntiXssEncoder.HtmlFormUrlEncode("text", Encoding.GetEncoding("UTF-8"));
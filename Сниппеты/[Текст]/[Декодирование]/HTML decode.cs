/*
* Декодирование строк, содержащих html-entities (мнемоники, https://www.w3schools.com/html/html_entities.asp ): &amp; &nbsp; &#169; и другие
*/

// переменная с закодированным содержимым
string content = project.Variables["content"].Value;

return System.Net.WebUtility.HtmlDecode(content);
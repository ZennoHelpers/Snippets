/*
* Декодирование строк, содержащих unicode представления символов (\u[код]).
*/

// переменная с закодированным содержимым
string content = project.Variables["content"].Value;

return Regex.Unescape(content);
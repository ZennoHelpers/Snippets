/*
* Декодирует base64 строку, корректно обрабатывая кириллические символы в UTF-8
*/

// переменная с закодированным содержимым
string base64Encoded = project.Variables["content"].Value;

byte[] data = Convert.FromBase64String(base64Encoded);
return Encoding.UTF8.GetString(data);
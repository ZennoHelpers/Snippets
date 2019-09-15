/*
* При получении ответа сервера в виде "Заголовки и содержимое" иногда нужно разделить заголовки от ответа.
*/

// переменная с ответом сервера (Заголовки и содержимое)
string response = project.Variables["response"].Value;

response = response.Trim();

// разделитель заголовков и содержимого
string[] separator = new string[] {"\r\n\r\n"};
// массив заголовков и содержимого (содержимое тоже может быть разбито на части)
string[] headers_and_body = response.Split(separator, StringSplitOptions.RemoveEmptyEntries);

// все заголовк строкой
string headers = String.Empty;
// всё содержимое строкой
string body = String.Empty;
// индикатор того, что заголовки закончились
bool headers_end = false;

foreach(string piece in headers_and_body) {
    // если заголовки не закончились и текущая часть начинается с 'http/' в любом регистре
    if(!headers_end && piece.StartsWith("HTTP/", StringComparison.OrdinalIgnoreCase)) {
        // это ещё заголовок
        headers = string.Concat(headers, separator[0] , piece);
    } else {
        // это уже содержимое
        body = string.Concat(body, separator[0], piece);
        headers_end = true;
    }
}

// избавляемся от пробелов и переводов строк на конце и начале
headers = headers.Trim();
body = body.Trim();

// записываем результат (заголовки и содержимое по отдельности) в zenno-переменные
project.Variables["splitted_headers"].Value = headers;
project.Variables["splitted_body"].Value = body;
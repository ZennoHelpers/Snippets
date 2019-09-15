/*
* Получение первого или последнего HTTP Status Code из заголовков.
* (Вначале заголовки нужно разбить с содержимым, см.: `Разбить ответ на заголовки и содержимое.cs`)
*/

// Заголовки (без содержимого!) лежат в переменной:
string headers = project.Variables["splitted_headers"].Value;

// Получить последний код ответа: true - да, false - первый
// Получать последний полезно, когда может быть редирект (301 код)
// А иногда наоборот нужно получить первый, чтоб понять не было ли редиректа
bool need_last_code = true;

// значения по умолчанию
string status_code = String.Empty;
string status_full = String.Empty;

try {
    string[] separator = new string[] {"\r\n\r\n"};
    string[] headers_delimited = headers.Split(separator, StringSplitOptions.RemoveEmptyEntries);

    // первый или последний код ответа
    int header_pos = 0;
    if (need_last_code) {
        header_pos = headers_delimited.Length - 1;
    }
    string required_header = headers_delimited[header_pos];

    string first_line = required_header.Substring(0, required_header.IndexOf('\n')+1);
    first_line = first_line.Trim().ToLower();

    string[] first_line_delimited = first_line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    first_line_delimited = first_line_delimited.Skip(1).ToArray(); // skip 'http/*.*'

    status_code = first_line_delimited[0]; // код: должно быть только число, например: 301
    status_full = string.Join(" ", first_line_delimited); // код и описание: 301 Moved Permanently
} catch (Exception exc) {
    // если что-то пошло не так (например, response_headers пустые) - берем значения по дефолту
}

// вернуть HTTP код ответа
return status_code;

// или вернуть целиком код и описание
// return status_full;
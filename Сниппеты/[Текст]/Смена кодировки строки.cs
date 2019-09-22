// Список кодировок https://docs.microsoft.com/ru-ru/dotnet/api/system.text.encoding

string text = "Текст";
string initial = "utf-8"; // исходная кодировка
string target = "cp866"; // требуемая на выходе кодировка

Encoding enc1 = Encoding.GetEncoding(initial);
Encoding enc2 = Encoding.GetEncoding(target);
byte[] enc2b = enc1.GetBytes(text);
byte[] enc1b = Encoding.Convert(enc2, enc1, enc2b);
return enc1.GetString(enc1b);
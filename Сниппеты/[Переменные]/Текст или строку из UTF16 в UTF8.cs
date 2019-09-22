// ТЕКСТ ИЛИ СТРОКУ ИЗ UTF16 В UTF8

//входная строка - unicodeString
//результат возвращается из asciistring

string unicodeString = "\u041f\u043e\u0436\u0430\u043b\u0443\u0439\u0441\u0442\u0430";

// Создание двух типов кодировок
Encoding ascii = Encoding.UTF8;
Encoding unicode = Encoding.Unicode;

// Конверитруем строку в массив байтов
byte[] unicodeBytes = unicode.GetBytes(unicodeString);

// Конвертация из Unicode в ASCII
byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

// Конвертация массива байтов byte[] в массив симвлов char[]
char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];

// Конвертация массива символов в строку
ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
string asciiString = new string(asciiChars);

// Вывод результата в лог
project.SendInfoToLog("", "Original string: " + unicodeString);
project.SendInfoToLog("", "ASCII converted string: " + asciiString);
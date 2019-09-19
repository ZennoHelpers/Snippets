// ВЗЯТЬ ДИАПОЗОН СТРОК ИЗ ФАЙЛА И ВЕРНУТЬ СТРОКУ ДОБАВИВ РАЗДЕЛИТЕЛЬ 

// путь к файлу
string path = project.Variables["pathToKeyWordFile"].Value;

// создаём список со строками
List<string> lines = File.ReadAllLines(path).ToList();

// возвращаем ключевые слова через ";" в указанном диапазоне от 3 до 6
// т.е. начиная с 2-го индекса в количестве 4 штуки
return string.Join(";", lines.GetRange(2, 4));
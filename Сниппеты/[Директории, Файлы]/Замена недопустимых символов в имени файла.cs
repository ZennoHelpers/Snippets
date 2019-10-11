// полезно для создания файла из автоматически генерируемого (или спаршенного) текста


// берем имя файла из Zenno-переменной title
string name = project.Variables["title"].Value;

// заменяем все недопустимые символы на следующий символ
char replace_to = '_';

// массив с недопустимыми символами в имени файла (также есть метод`Path.GetInvalidPathChars()` - для директорий)
IEnumerable<char> invalidFileChars = Path.GetInvalidFileNameChars();
// в кубике "Файлы для загрузки" через запятую сделана загрузка нескольких файлов, поэтому стоит заменять этот символ тоже
invalidFileChars = invalidFileChars.Append(',');

foreach(char find in invalidFileChars) {
	name = name.Replace(find, replace_to);
}

return name;
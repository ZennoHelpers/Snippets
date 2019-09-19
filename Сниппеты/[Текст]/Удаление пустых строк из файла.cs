// Delete blank lines from file
// Удалить пустые строки в файле
// Gets file path from your project variable with name "filePath"
// Получаем путь к файлу из переменной "filePath"
string path = project.Variables["filePath"].Value; 
var lines = System.IO.File.ReadAllLines(path).Where(arg => !string.IsNullOrWhiteSpace(arg));
System.IO.File.WriteAllLines(path, lines);

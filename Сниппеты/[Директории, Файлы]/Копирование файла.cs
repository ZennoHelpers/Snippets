// Копирование файла в текущей директории проекта, для копирования внутри папки, добавить её вторым параметром в Path.Combine

// файл для копирования
string from_file_name = @"copy.docx";

// имя копии файла
string to_file_name = @"result.docx";

// путь до текущей директории проекта
string directory = project.Directory;

string from = Path.Combine(directory, from_file_name);
string to = Path.Combine(directory, to_file_name);

// копирование файла
File.Copy(from, to);

// Копирование файла в текущей директории проекта, для копирование внутри папки, добавить её вторым параметром в Path.Combine

// файл для копирования
string from_file_name = @"copy.docx";

// имя копии файла
string to_file_name = @"result.docx";

// путь до текущей директории проекта
string directory = project.Directory;

// т.к. в пути могут быть различные символы, для упрощения используем Path.Combine
string[] fromPaths = {directory, from_file_name};
string from = Path.Combine(fromPaths);

string[] toPaths = {directory, to_file_name};
string to = Path.Combine(toPaths);

// копирование файла
File.Copy(from, to);

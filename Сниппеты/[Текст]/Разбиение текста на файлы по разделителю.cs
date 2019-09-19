// исходный текст из переменной проекта
string inputText = project.Variables["text"].Value;

// исходный текст из файла
//string inputText = File.ReadAllLines(project.Directory+"\\text.txt");

// разделитель
string separator = "###";

// создаём массив и наполеяем его элементами (текстами) по разделителю
string[] text = inputText.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

// перебираем массив и на основе каждого элемента создаём файл в папке с проектом
for (int i = 0; i < text.Length; i++)
{
	File.WriteAllText(project.Directory+"\\"+ i + ".txt", text[i].Trim());
}
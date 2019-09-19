// ВСТАВКА КЛЮЧЕЙ В ТЕКСТ ИЗ СПИСКА В СЛУЧАЙНОМ ПОРЯДКЕ

// создание рандома
Random rnd = new Random();

// список ключей
IZennoList keywords = project.Lists["keywords"];

// минимальное кол-во слов, после которых вставлять ключи
int min = 200; 
 // максимальное кол-во слов
int max = 500;

// текст для изменения
string text = project.Variables["text"].Value;
 
 // массив из слов input текста
string[] words;

// переменная с результирующим текстом
string result = string.Empty;

// генерация случайного числа после которого будет вставлен ключ
int r = rnd.Next(min, max);
 
// помещаем все слова текста в массив (текст делится по пробелу)
words = text.Split(' ');

// перебираем массив по слову
for (int i = 0; i < words.Length; i++)
{
	// если порядковый номер слова равно случайному числу для вставки ключа 
	if (i == r)
	{
		// вставляем случайный ключ из списка
		result += keywords[rnd.Next(keywords.Count)] + " " + words[i] + " ";
		r = r + rnd.Next(min, max);
	}
	
	// иначе к слову добавляем пробел без изменений
	else
	{
		result += words[i] + " ";
	}
}

return text = result.Trim();
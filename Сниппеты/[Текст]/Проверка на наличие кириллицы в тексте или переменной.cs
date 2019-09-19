// ПРОВЕРКА НА НАЛИЧИЕ КИРИЛЛИЦЫ В ТЕКСТЕ / ПЕРЕМЕННОЙ

string inputText = project.Variables["text"].Value;

if (Regex.Match(inputText, "[А-Яа-яЁё]").Success)
{
	return "Присутствуют кириллические символы";
}
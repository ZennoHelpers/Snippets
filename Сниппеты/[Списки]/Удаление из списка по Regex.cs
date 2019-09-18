// УДАЛЕНИЕ ИЗ СПИСКА ПО REGEX //

// Добавить в OwnCode (Общий код) в конце:
/* namespace ZennoHelpers
{
	public class Locker
	{
		public static object CustomListSyncer = new object();
	}
} */

// берем регулярное выражение для парсинга из переменной
var parserRegexPattern = project.Variables["listSearchRegex"].Value;
var parserRegex = new System.Text.RegularExpressions.Regex(parserRegexPattern);

// получаем список, в котором будем искать
var sourceList = project.Lists["SourceList"];

int lstCount = sourceList.Count;

// ищем в каждой строчке в списке
lock(ZennoHelpers.Locker.CustomListSyncer)
{
	for(int i = sourceList.Count-1; i >= 0; i--)
	{
		// читаем строку из списка
		var str = sourceList[i];
		// проверяем строку регулярным выражением, если есть совпадение удаляем
		if (parserRegex.IsMatch(str))
		{
			sourceList.RemoveAt(i);
		}
	}
}
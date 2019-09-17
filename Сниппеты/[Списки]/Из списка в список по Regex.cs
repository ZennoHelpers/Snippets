/* ПОИСК В СПИСКЕ ПО РЕГУЛЯРНОМУ ВЫРАЖЕНИЮ
И КОПИРОВАНИЕ РЕЗУЛЬТАТОВ В ДРУГОЙ  */

// берем регулярное выражение для парсинга из переменной
var parserRegexPattern = project.Variables["listSearchRegex"].Value;
var parserRegex = new System.Text.RegularExpressions.Regex(parserRegexPattern);

// получаем список, в котором будем искать
var sourceList = project.Lists["SourceList"];

// получаем список, в который будем класть
var destList = project.Lists["OutputList"];

// ищем в каждой строчке в списке
lock(SyncObjects.ListSyncer)
{
    for(int i=0; i < sourceList.Count; i++)
    {
        // читаем строку из списка
        var str = sourceList[i];
        // проверяем строку регулярным выражением, если есть совпадение кладем результат во второй список
        if (parserRegex.IsMatch(str))
        {
            destList.Add(str);      
        }
    }
	
	// return string.Join(", ", destList); - убрать комментарий, если нужно вернуть список в переменную с разделителем.
}
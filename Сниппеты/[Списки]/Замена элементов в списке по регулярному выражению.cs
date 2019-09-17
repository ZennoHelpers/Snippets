/* ЗАМЕНА ЭЛЕМЕНТОВ В СПИСКЕ ПО РЕГУЛЯРНОМУ ВЫРАЖЕНИЮ */

// получаем список, в котором будем искать
var sourceList = project.Lists["SourceList"];
 
 // Регулярное выражение по поиску чисел
var parserRegex = new Regex("\\d{1,2}");
 
lock(SyncObjects.ListSyncer)
{
	// Пробегаемся по списку
    for(int i=0; i < sourceList.Count; i++)
    {
		// Если элемент соответствует регулярному выражению
        if (parserRegex.IsMatch(sourceList[i]))
        {
			// Заменяем текущий элемент на REPLACED
            sourceList[i]= "REPLACED";
        }
    }
}
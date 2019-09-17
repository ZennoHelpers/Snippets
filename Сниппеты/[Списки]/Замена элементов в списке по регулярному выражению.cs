/* http://zennolab.com/discussion/threads/poisk-zamena-v-spiske.18675/#post-120043
Подскажите, пожалуйста, как осуществить поиск-замену в списке, в том числе по регулярному выражению?
Или хотя бы, как добавить какое-то определенное выражение (фразу) в начало каждой строки списка? Количество строк всегда рандомное! */

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
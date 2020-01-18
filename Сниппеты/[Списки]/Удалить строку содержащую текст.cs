// берем из переменной текст, который надо искать
var textContains = project.Variables["Переменная"].Value;
// получаем список, в котором будем искать
var sourceList = project.Lists["Список"];
// ищем в каждой строчке в списке
lock(SyncObjects.ListSyncer)
{
    for(int i=0; i < sourceList.Count; i++)
    {
        // читаем строку из списка
        var str = sourceList[i];
        // проверяем содержание текста в строке, если есть совпадение возвращаем "yes"
        if (str.Contains(textContains))
        {
            //удаляем строку содержащую текст
             sourceList.RemoveAt(i);
             // без "i--;" обработка будет некорректной, будет пропускаться строка идущая сразу после удаляющейся строки.
             i--;
        }
    }
}

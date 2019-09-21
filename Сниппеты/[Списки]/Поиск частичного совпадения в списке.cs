// берем из переменной текст, который надо искать
var textContains = project.Variables["tmpCity"].Value;
// получаем список, в котором будем искать
var sourceList = project.Lists["city"];
// ищем в каждой строчке в списке
lock(CommonCode.SyncObject)
{
	for(int i=0; i < sourceList.Count; i++)
	{
		// читаем строку из списка
		var str = sourceList[i];
		// проверяем содержание текста в строке, если есть совпадение возвращаем "yes"
		if (str.Contains(textContains))
		{
			return "yes";
		}
	}
}
// если ничего не нашли возвращаем "no"
return "no";
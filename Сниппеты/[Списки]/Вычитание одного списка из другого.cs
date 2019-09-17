/* ВЫЧИТАНИЕ ОДНОГО СПИСКА ИЗ ДРУГОГО
ПОЛЕЗНО ПРИ РЕАЛИЗАЦИИ ЧЁРНОГО СПИСКА */

// BlackList - список с игнорируемыеми элементами
List<string> blackList = project.Lists["BlackList"].ToList();

 // SourceList - исходный список
List<string> sourceList = project.Lists["SourceList"].ToList();

// ResultList - результат вычитания исходного списка и чёрного списка
IZennoList resultList = project.Lists["ResultList"];

lock(SyncObjects.ListSyncer)
{
	List<string> exclude = new List<string>();
	exclude = sourceList.Except(blackList).ToList();
	resultList.AddRange(exclude);
}
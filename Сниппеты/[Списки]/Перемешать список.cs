// ПЕРЕМЕШАТЬ СПИСОК

IZennoList sourceList = project.Lists["SourceList"];
sourceList.Shuffle();

// АЛЬТЕРНАТИВНАЯ РЕАЛИЗАЦИЯ С ВОЗМОЖНОСТЬЮ ВЛОЖИТЬ ДОП. ЛОГИКУ

// создание рандома
/* Random rnd = new Random();

for (int i = 0; i < project.Lists["SourceList"].Count; i++)
{
	string tmp = project.Lists["SourceList"][0];
	project.Lists["SourceList"].RemoveAt(0);
	project.Lists["SourceList"].Insert(rnd.Next(project.Lists["SourceList"].Count), tmp);
} */
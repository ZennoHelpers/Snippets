// ПЕРЕМЕШАТЬ СПИСОК

// создание рандома
Random rnd = new Random();

for (int i = 0; i < project.Lists["SourceList"].Count; i++)
{
	string tmp = project.Lists["SourceList"][0];
	project.Lists["SourceList"].RemoveAt(0);
	project.Lists["SourceList"].Insert(rnd.Next(project.Lists["SourceList"].Count), tmp);
}

project.SendInfoToLog(project.Lists["SourceList"].ToString());

// АЛЬТЕРНАТИВНАЯ РЕАЛИЗАЦИЯ
/* IZennoList sourceList = project.Lists["SourceList"];
sourceList.Shuffle(); */
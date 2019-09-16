IZennoList list = project.Lists["List"];
int rnd = new Random().Next(0, list.Count);
return list.ElementAt(rnd);
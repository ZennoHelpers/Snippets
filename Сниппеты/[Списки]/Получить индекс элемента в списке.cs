// ПОЛУЧИТЬ ИНДЕКС ЭЛЕМЕНТА (СТРОКИ) В СПИСКЕ

// значение элемента (строки) для которого нужно получить индекс в списке
string url = project.Variables["url"].Value;

// список элементов (строк)
IZennoList sourceLst = project.Lists["SourceList"];
return sourceLst.IndexOf(url);
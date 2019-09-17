// ДОБАВИТЬ ЭЛЕМЕНТ В СПИСОК ИЗ ПЕРЕМЕННОЙ ПРОЕКТА

IZennoList list = project.Lists["SourceList"];
string someText = project.Variables["someText"].Value;
list.Add(someText);
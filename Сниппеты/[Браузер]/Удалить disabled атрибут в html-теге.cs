/*
* Удалить атрибут disabled из тега и сделать его активным.
*/

// получить тег любым способом, например, через ID
HtmlElement he = instance.ActiveTab.MainDocument.FindElementById("ID_тега");

// удалить атрибут
he.RemoveAttribute("disabled");
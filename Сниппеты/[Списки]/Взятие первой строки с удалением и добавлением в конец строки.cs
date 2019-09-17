/* ВЗЯТИЕ ПЕРВОЙ СТРОКИ С УДАЛЕНИЕМ И ДОБАВЛЕНИЕМ В КОНЕЦ СПИСКА 
Полезно при работе с прокси и других функциях, где необходимо поддержание первоначального списка элементов */

// список с прокси
IZennoList proxyList = project.Lists["proxyList"]; 

string proxy;

lock(SyncObjects.ListSyncer)
{
	string proxy = ProxyList[0];
	ProxyList.RemoveAt(0);
	ProxyList.Add(proxy);
}

// значение proxy из списка в переменную проекта
project.Variables["proxy"].Value = proxy;


	
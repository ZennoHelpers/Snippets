/* ВЗЯТИЕ ПЕРВОЙ СТРОКИ С УДАЛЕНИЕМ И ДОБАВЛЕНИЕМ В КОНЕЦ СПИСКА 
Полезно при работе с прокси и других функциях, где необходимо поддержание первоначального списка элементов */

// Добавить в OwnCode (Общий код) в конце:
/* namespace ZennoHelpers
{
	public class Locker
	{
		public static object CustomListSyncer = new object();
	}
} */

// список с прокси
IZennoList proxyList = project.Lists["proxyList"]; 

string proxy;

lock(ZennoHelpers.Locker.CustomListSyncer)
{
	string proxy = ProxyList[0];
	ProxyList.RemoveAt(0);
	ProxyList.Add(proxy);
}

// значение proxy из списка в переменную проекта
project.Variables["proxy"].Value = proxy;
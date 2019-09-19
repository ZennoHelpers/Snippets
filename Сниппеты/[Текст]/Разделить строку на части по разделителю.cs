/* РАЗДЕЛИТЬ СТРОКУ НА ЧАСТИ ПО РАЗДЕЛИТЕЛЮ
Ваозможное использвание: разбиение данных аккаунтов, прокси на переменные итп. */

// ":" - разделитель в строке
string[] ipPortAsArray = project.Variables["AccountData"].Value
	.Split(new string[] { ":" },
	StringSplitOptions.RemoveEmptyEntries);
	
// перебор массива
foreach (string data in ipPortAsArray)
{
	// какой-то код
}
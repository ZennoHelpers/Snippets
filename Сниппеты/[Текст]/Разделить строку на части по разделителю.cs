/* РАЗДЕЛИТЬ СТРОКУ НА ЧАСТИ ПО РАЗДЕЛИТЕЛЮ
Ваозможное использвание: разбиение данных аккаунтов, прокси на переменные итп. */

// Результат в список
// ":" - разделитель в строке
List<string> ipPortAsList = new List<string>(
	project.Variables["AccountData"].Value.Split(new string[] { ":" },
	StringSplitOptions.RemoveEmptyEntries));
	
		// перебор листа
foreach (string data in ipPortAsList)
{
	// какой-то код
}

// Результат в массив
// ":" - разделитель в строке
string[] ipPortAsArray = project.Variables["AccountData"].Value
	.ToString()
	.Split(new string[] { ":" },
	StringSplitOptions.RemoveEmptyEntries);
	
	// перебор массива
foreach (string data in ipPortAsArray)
{
	// какой-то код
}
/*
* Возвращает число секунд (без миллисекунд), прощедших с начала "Эпохи Unix".
*/

long unixtime = DateTimeOffset.Now.ToUnixTimeSeconds();
return Convert.ToString(unixtime);
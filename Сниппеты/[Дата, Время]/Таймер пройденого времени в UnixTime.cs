// ТАЙМЕР ПРОЙДЕННОГО ВРЕМЕНИ В UNIXTIME

// Стартовое время в UnixTime
long startTime  = long.Parse(project.Variables["startTime"].Value);

// Время сейчас в UnixTime
long unixTimeNow = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();

// Получаем количество прошедших секунд от начала отсчёта
return unixTimeNow - startTime;
// ТАЙМЕР ПРОЙДЕННОГО ВРЕМЕНИ ПО ДАТЕ

// Стартовое время в формате даты
DateTime dateTimeStart  = DateTime.Parse(project.Variables["startTime"].Value);
long unixTimeStart = ((DateTimeOffset)dateTimeStart).ToUnixTimeSeconds();

//Время сейчас в UnixTime
long unixTimeNow = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();

// Получаем количество прошедших секунд от начальной даты
return unixTimeNow - unixTimeStart;
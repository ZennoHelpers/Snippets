//ИЗ UNIXTIME В DATETIME

// переменная с UnixTime
long unixTime = long.Parse(project.Variables["unixTime"].Value);

DateTime dateTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(unixTime).ToLocalTime();

// возможно вывести в нужном формате
return dateTime.ToString();
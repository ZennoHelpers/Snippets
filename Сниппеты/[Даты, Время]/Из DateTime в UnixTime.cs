// ИЗ DATETIME В UNIXTIME

// время, которое необходимо получить в UnixTime
DateTime time = DateTime.Parse(project.Variables["date"].Value);

// установка времени
 DateTime dateTime = new DateTime(1970, 1, 1,0,0,0,DateTimeKind.Utc);

// время в UnixTime
return (long)(time - dateTime).TotalSeconds;
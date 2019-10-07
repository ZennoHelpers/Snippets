// специальный таймер для замера времени выполнения кода

// Для работы необходимо добавить в "Директивы Using":
// using System.Diagnostics;

// определяем объект таймера и начинаем отсчёт
Stopwatch timer = new Stopwatch();
timer.Start();

// для примера делаем паузу 12 секунд 345 миллисекунд
Thread.Sleep(12345);

// останавливаем замер
timer.Stop();

// конвертируем полученные значения и собираем строку с результатом
TimeSpan ts = timer.Elapsed;
string elapsedTime = String.Format(
	"{0:00}h:{1:00}m:{2:00}s.{3:00}ms",
	ts.Hours,
	ts.Minutes,
	ts.Seconds,
	ts.Milliseconds
);

// выводим результат в лог ProjectMaker
project.SendInfoToLog(elapsedTime);
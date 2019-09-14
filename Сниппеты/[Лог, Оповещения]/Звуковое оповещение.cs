// 1 вариант

System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"путь к файлу wav");
player.Play();

// 2 вариант

System.Media.SystemSounds.Asterisk.Play();
System.Media.SystemSounds.Beep.Play();
System.Media.SystemSounds.Exclamation.Play();
System.Media.SystemSounds.Question.Play(); // на win10 нет звука по умолчанию
System.Media.SystemSounds.Hand.Play(); // звук ошибки

// 3 вариант

Console.Beep(800, 500); // частота сигнала и длительность, мс
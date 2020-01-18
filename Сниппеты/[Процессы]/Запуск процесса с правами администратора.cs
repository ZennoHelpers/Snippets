Process process = new Process();
process.StartInfo.FileName = "cmd";
process.StartInfo.Arguments = "/c for /F \"tokens=*\" %1 in ('wevtutil.exe el') DO wevtutil.exe cl \"%1\"";
process.StartInfo.Verb = "runas"; // запуск с правами администратора
process.StartInfo.CreateNoWindow = false;// поменять на true если не хотите видеть окно консоли
process.Start();     
process.WaitForExit();

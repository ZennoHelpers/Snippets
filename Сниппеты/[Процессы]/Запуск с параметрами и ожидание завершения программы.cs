System.Diagnostics.Process process = new System.Diagnostics.Process {
	StartInfo = new System.Diagnostics.ProcessStartInfo {
		UseShellExecute = false,
		RedirectStandardOutput = true,  
		RedirectStandardError = true,
		RedirectStandardInput = true,
		CreateNoWindow = true,
		FileName = @"C:\Windows\System32\cmd.exe", // путь к запускаемой программе
		WorkingDirectory = @"C:\Windows\System32", // рабочая папка
		Arguments = "/c echo hellow world" // аргументы
	}
};

process.Start();
string output = process.StandardOutput.ReadToEnd();
process.WaitForExit();

// process.Close(); // Dispose его вызывает сам
process.Dispose(); // освобождение ресурсов

return output;
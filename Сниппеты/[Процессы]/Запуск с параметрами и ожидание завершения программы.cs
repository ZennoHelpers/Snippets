Process process = new System.Diagnostics.Process {
	StartInfo = new System.Diagnostics.ProcessStartInfo {
		UseShellExecute = false,
		RedirectStandardOutput = true,  
		RedirectStandardError = true,
		RedirectStandardInput = true,
		CreateNoWindow = true,
		FileName = "cmd.exe",
		WorkingDirectory = "рабочая_папка",
		Arguments = "/c echo hellow world" // аргументы
	}
};

process.Start();
string output = process.StandardOutput.ReadToEnd();
process.WaitForExit();

process.Close();
process.Dispose();
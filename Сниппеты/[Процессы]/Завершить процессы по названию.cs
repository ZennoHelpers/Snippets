foreach (var process in System.Diagnostics.Process.GetProcessesByName("notepad"))
{
    process.Kill();
}
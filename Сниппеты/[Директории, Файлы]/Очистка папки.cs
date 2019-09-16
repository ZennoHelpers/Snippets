DirectoryInfo di = new DirectoryInfo(Environment.ExpandEnvironmentVariables("%Temp%")); // new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Temp")

foreach (DirectoryInfo dir in di.GetDirectories())
{
    try
    {
        dir.Delete(true);
    }
    catch { }
}

foreach (FileInfo file in di.GetFiles())
{
    try
    {
        file.Delete();
    }
    catch { }
}
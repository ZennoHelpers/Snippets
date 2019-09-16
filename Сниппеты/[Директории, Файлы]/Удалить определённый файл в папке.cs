DirectoryInfo dir = new DirectoryInfo(project.Variables["FolderPath"].Value);
foreach (FileInfo file in dir.GetFiles())
{
	if (file.Name == project.Variables["FilePath"].Value)
	{
		file.Delete();
	}
}
string url = project.Variables["url"].Value;
IZennoList check = project.Lists["List"];
return check.IndexOf(url);
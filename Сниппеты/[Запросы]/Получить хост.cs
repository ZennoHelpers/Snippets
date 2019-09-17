string url = project.Variables["url"].Value;
return new Uri(url).Host;
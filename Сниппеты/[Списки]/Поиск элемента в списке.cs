IZennoList list = project.Lists["BlackList"]; 
string id = project.Variables["id"].Value;
return list.Contains(id).ToString();
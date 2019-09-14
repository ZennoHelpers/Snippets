string projPath = project.Directory + @"\example.xmlz";
var mapVars = new List<Tuple<string, string>>
{
	new Tuple<string, string>("projectVarNameA1", "projectVarNameA2"),
	new Tuple<string, string>("projectVarNameB1", "projectVarNameB2"),
};
bool isSuccess = project.ExecuteProject(projPath, mapVars, true, true, true);
if(!isSuccess) throw new Exception(@"Подпроект " + projPath + @" не выполнен.");
IZennoTable table = project.Tables["table1"]; // Применяется к таблице: table1
List<IEnumerable<string>> tmplist = new List<IEnumerable<string>>();
while(table.RowCount > 0){
	tmplist.Add(table.GetRow(0));
	table.DeleteRow(0);
}
tmplist.Shuffle();
foreach(IEnumerable<string> list in tmplist)
{
	table.AddRow(list);
}
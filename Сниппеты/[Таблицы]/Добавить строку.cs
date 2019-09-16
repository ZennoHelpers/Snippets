IZennoTable table = project.Tables["MyTable"];
// table.ColSeparator = ";";
lock(SyncObjects.ListSyncer)
{
    table.AddRow("one;two;three;four");
}
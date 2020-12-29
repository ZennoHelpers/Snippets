using (FileSyncObjects.ListSyncer.Lock())
{
    //код со списками
}
using (FileSyncObjects.TableSyncer.Lock())
{
    //код с таблицами
}
using (FileSyncObjects.GoogleSpreadsheetsSyncer.Lock())
{
    //код с гугл таблицами
}

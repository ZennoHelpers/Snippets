// FileSyncObjects.ListSyncer.Lock() - для списков
// FileSyncObjects.TableSyncer.Lock() - для таблиц
// FileSyncObjects.GoogleSpreadsheetsSyncer.Lock()  - для google таблиц

// Например:
lock(FileSyncObjects.TableSyncer.Lock())
{
    // Тут блокируемый код записи/чтения таблицы, чей привязанный файл общий между шаблонами
}

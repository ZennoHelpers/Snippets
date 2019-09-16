SyncObjects.InputSyncer
SyncObjects.ListSyncer
SyncObjects.TableSyncer

// Например:
lock(SyncObjects.TableSyncer)
{
    // Тут блокируемый код, например, работы с таблицей, чей привязанный файл общий между шаблонами
}
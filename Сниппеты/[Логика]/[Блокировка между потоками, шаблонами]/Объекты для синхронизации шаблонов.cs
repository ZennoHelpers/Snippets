//SyncObjects.InputSyncer - для ввода
//SyncObjects.ListSyncer - для списков
//SyncObjects.TableSyncer - для таблиц

// Например:
lock(SyncObjects.TableSyncer)
{
    // Тут блокируемый код записи/чтения таблицы, чей привязанный файл общий между шаблонами
}
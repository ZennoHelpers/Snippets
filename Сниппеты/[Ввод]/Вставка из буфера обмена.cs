/*
* Вставка текста на странице через использование CTRL+V.
* Обсуждение на форуме: https://zennolab.com/discussion/threads/33359/
*/

// текст для вставки
string content = project.Variables["content"].Value;

 // блокировка для многопоточной работы
lock(SyncObjects.InputSyncer) {
    // сохраняем предыдущее состояние буфера
    String previous_text = null;
    previous_text = System.Windows.Forms.Clipboard.GetText();

    // сохраняем нужный текст в буфер и вставляем его (программно делаем CTRL+V)
    System.Windows.Forms.Clipboard.SetText(content);
    instance.ActiveTab.KeyEvent("v", "press", "ctrl");

    // стираем буфер и если первоначальный не пустой, то возвращаем его
    System.Windows.Forms.Clipboard.Clear();
    if (!String.IsNullOrEmpty(previous_text)) {
        System.Windows.Forms.Clipboard.SetText(previous_text);
    }
}

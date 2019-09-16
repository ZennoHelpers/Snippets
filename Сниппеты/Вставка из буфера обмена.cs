lock(SyncObjects.InputSyncer) // блокировка между всеми шаблонами
{
    var descr = project.Variables["content"].Value;
 
    // сохраняем нужный текст в буфер и вставляем его (программно делаем CTRL+V)
    System.Windows.Forms.Clipboard.SetText(descr);
    instance.ActiveTab.KeyEvent("v","press","ctrl");
 
    // стираем буфер
    System.Windows.Forms.Clipboard.Clear();
}
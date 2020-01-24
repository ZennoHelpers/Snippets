// Эмуляция списка шрифтов для Firefox
// Отключает рандомно половину системных шрифтов
var fonts = instance.GetFonts().ToList();
Random r = new Random();
foreach(var res in fonts) {
    if (r.Next(0, 10) > 5) 
    {
        instance.HideFont(res);
    }
}

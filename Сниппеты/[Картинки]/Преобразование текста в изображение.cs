// ПРЕОБРАЗОВАНИЕ ТЕКСТА В ИЗОБРАЖЕНИЕ

//ДОБАВИТЬ ДИРЕКТИВЫ USING

//using System.Drawing;
//using System.Drawing.Text;
//using System.Drawing.Drawing2D;

var imageText = "imageText"; // Текст
 
Bitmap bitmap = new Bitmap(1, 1);
 
int width = 0;
int height = 0;
 
// Создаем объект Font для "рисования" им текста.
Font font = new Font("Arial", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
 
// Создаем объект Graphics для вычисления высоты и ширины текста.
Graphics graphics = Graphics.FromImage(bitmap);
 
// Определение размеров изображения.
width = (int)graphics.MeasureString(imageText, font).Width;
height = (int)graphics.MeasureString(imageText, font).Height;
 
// Пересоздаем объект Bitmap с откорректированными размерами под текст и шрифт.
bitmap = new Bitmap(bitmap, new Size(width, height));
 
// Пересоздаем объект Graphics
graphics = Graphics.FromImage(bitmap);
 
// Задаем цвет фона.
graphics.Clear(Color.White);

// Задаем параметры анти-алиасинга
graphics.SmoothingMode = SmoothingMode.AntiAlias;
graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

// Пишем (рисуем) текст
graphics.DrawString(imageText, font, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
graphics.Flush();
 
bitmap.Save(@"D:\image.jpg"); // Путь для сохранения полученной картинки
 
bitmap.Dispose();
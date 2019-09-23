/*
* Возвращает строку "[Ширина]x[Высота]" (без фигурных скобок).
*/

// полный(!) путь к картинке
string image_path = project.Variables["image_path"].Value;

using (Image image = Image.FromFile(image_path))
{
    return String.Format("{0}x{1}", image.Width, image.Height);
}
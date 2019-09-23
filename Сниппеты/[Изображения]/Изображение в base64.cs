/*
* Конвертирует изображение в base64 кодировку.
*/

// полный(!) путь к картинке
string image_path = project.Variables["image_path"].Value;

using (Image image = Image.FromFile(image_path))
{
    using (MemoryStream m = new MemoryStream())
    {
        image.Save(m, image.RawFormat);
        byte[] imageBytes = m.ToArray();
        string base64String = Convert.ToBase64String(imageBytes);
        return base64String;
    }
}
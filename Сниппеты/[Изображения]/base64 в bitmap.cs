string base64 = project.Variables["base64"].Value; // изображение в base64
Bitmap bitmap = new Bitmap(new MemoryStream(Convert.FromBase64String(base64))); // base64 to bitmap

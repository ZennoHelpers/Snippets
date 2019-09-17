/*
* Закодировать содержимое переменной в MD5 хеш.
*/

// Получаем значение строки из переменной
string input = project.Variables["input"].Value;


System.Security.Cryptography.MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
StringBuilder md5hash = new StringBuilder();
for (int i = 0; i < data.Length; i++)
{
    md5hash.Append(data[i].ToString("x2"));
}

// Возвращаем MD5 хеш для строки
return md5hash.ToString();
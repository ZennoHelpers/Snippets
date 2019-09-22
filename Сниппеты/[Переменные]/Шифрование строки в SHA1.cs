/* ШИФРОВАНИЕ СТРОКИ В SHA1

Иногда встречаются сайты, которые требуют шифрование cookies в SHA1

*/

// В ДИРЕКТИВЫ USINGS ДОБАВИТЬ
// using System.Security.Cryptography;

// строка для шифрования
string inputVariable = project.Variables["inputVariable"].Value;

// инициализация результирующей переменной
string hash = string.Empty;

// получаем массив байтов строки в кодировке ASCII
byte[] byteArray = Encoding.ASCII.GetBytes(inputVariable);

// предстваление массива байтов алгоритом SHA1
byte[] hashData = new SHA1Managed().ComputeHash(byteArray);

// перебираем массив и представляем каждый элемент в десятичной системе
foreach (var b in hashData)
{
	hash += b.ToString("X2");
}

return hash.ToLower();
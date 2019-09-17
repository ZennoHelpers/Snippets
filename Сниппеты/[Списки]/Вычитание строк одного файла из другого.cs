/* ВЫЧИТАНИЕ СТРОК ОДНОГО ФАЙЛА ИЗ ДРУГОГО
ПОЛЕЗНО ПРИ РЕАЛИЗАЦИИ ЧЁРНОГО СПИСКА */

// Исходный файл источник
var txtList1 = File.ReadAllLines(@"F:\Downloads\list1.txt");
List<string> list1 = new List<string>(txtList1);

// Файл  с игнорируемыеми элементами
var txtList2 = File.ReadAllLines(@"F:\Downloads\list2.txt");
List<string> list2 = new List<string>(txtList2);

// Коллекция - результат вычитания исходного файла и игнорируемого
IEnumerable<string> list3 = Enumerable.Empty<string>(); 

// Вычитание
list3 = list1.Except(list2);

// Запись в файл
File.WriteAllLines(@"F:\result.txt", list3);
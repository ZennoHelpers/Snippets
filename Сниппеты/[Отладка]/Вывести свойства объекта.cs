/*
* Выводит свойства объекта (не рекурсивно) со значениями, полезно при отладке.
*/

// заменить на свой объект с таким же именем
object obj_name = new Uri("http://zennolab.com");

foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj_name)) {
    string name = descriptor.Name;
    object value = descriptor.GetValue(obj_name);
    project.SendInfoToLog(String.Format("{0}={1}", name, value));
}
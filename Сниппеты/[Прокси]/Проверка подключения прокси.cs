 # Проверка подключения прокси в проекте. Выдает исключение, если прокси не установилось на каком-то этапе.
 # Источник: https://zennolab.com/discussion/threads/zaxodim-na-sajt-maksimalno-bezopasno-bonus-x2.70093/post-505881
 
 if(project.GetProxy() == string.Empty) {
   throw new Exception("Прокси проекта не установлен");
 }
 
if(instance.GetProxy() == string.Empty){
  throw new Exception("Прокси инстанса не установлен");
}

if(instance.GetProxy() == project.Environment.IpAddress) {
  throw new Exception("Прокси инстанса совпадает с внешним IP");
}

if(project.GetProxy() == project.Environment.IpAddress){
  throw new Exception("Прокси проекта совпадает с внешним IP");
}

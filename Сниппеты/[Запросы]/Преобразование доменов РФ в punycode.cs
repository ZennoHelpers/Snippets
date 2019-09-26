// На вход подается имя домена без http и пути, на выходе получаем результат в punycode
// Пример: программисту.рф => xn--80afqpaigicolm.xn--p1ai
// Данное преобразование необходимо для добавления в конфиги, проверки данных в сервисах через API

System.Globalization.IdnMapping idn = new System.Globalization.IdnMapping();
return idn.GetAscii(project.Variables["domain"].Value);

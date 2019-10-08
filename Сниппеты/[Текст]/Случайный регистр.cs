// сниппет делает случайный рЕгИсТР тексту, основываясь на заданных вероятностях

// текст из Zenno-переменной для изменения
string text = project.Variables["text"].Value;

// вероятность, что будем менять каждую букву
int chance = 70;
// вероятность, что поменяем регистр на ПРОПИСНЫЕ
int chance_2upper = 30;
// вероятность, что поменяем регистр на строчный
int chance_2lower = 45;

string new_text = String.Empty;
Random rnd = new Random();

for (int i=0; i<text.Length; i++) {
	bool changed = false;
	if (rnd.Next(0, 100) <= chance) {
		if (rnd.Next(0, 100) <= chance_2upper) {
			new_text += Convert.ToString(text[i]).ToUpper();
			changed = true;
		} else {
			if (rnd.Next(0, 100) <= chance_2lower) {
				new_text += Convert.ToString(text[i]).ToLower();
				changed = true;
			}
		}
	}
	
	if (!changed) {
		new_text += text[i];
	}
}

return new_text;
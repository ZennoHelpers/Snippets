// ОКНО С ДИАЛОГОМ "ДА" ИЛИ "НЕТ"

// показываем сообщение
System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Нажмите \"Да\" или \"Нет\"", "Заголовок", System.Windows.Forms.MessageBoxButtons.YesNo);

// если да
if (result == System.Windows.Forms.DialogResult.Yes)
{
	 System.Windows.Forms.MessageBox.Show("Вы нажали \"Да\"");
	 return "YES";
}

// если нет
if (result == System.Windows.Forms.DialogResult.No)
{
	 System.Windows.Forms.MessageBox.Show("Вы нажали \"Нет\"");
	 return "NO";
}
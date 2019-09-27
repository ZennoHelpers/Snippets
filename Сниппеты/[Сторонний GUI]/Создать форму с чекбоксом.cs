// СОЗДАНИЕ ФОРМЫ С ЧЕКБОКСОМ

// В GAC добавить System.Windows.Forms.dll

var dialogForm = new System.Windows.Forms.Form
{
	Size = new Size(450, 110), ShowIcon = false, Name = "DialogForm", Text = @"Форма",
	FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false
};

// создаём контрол
var checkbox = new System.Windows.Forms.CheckBox { Name = "CheckBox", Text = "Чек бокс" };
dialogForm.Controls.Add(checkbox);
checkbox.Location = new Point(12, 12);

// событие Check
checkbox.CheckedChanged += (delegate
{
	/* ВОТ ЗДЕСЬ ОБРАБОТКА СОБЫТИЯ Т.Е. ТЕЛО МЕТОДА. К ПРИМЕРУ */
	if (checkbox.Checked) System.Windows.Forms.MessageBox.Show("Значение изменилось на true", "Обработка события CheckedChanged");
	else System.Windows.Forms.MessageBox.Show("Значение изменилось на false", "Обработка события CheckedChanged");
} );

// показываем форму
var dialogResult = dialogForm.ShowDialog();
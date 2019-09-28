// СОЗДАНИЕ ФОРМЫ С ПОЛЕМ ВВОДА

/* В случае нажатия "ок"- текст из поля вводапопадет в результирующую переменную,
а если будет нажата отмена, то вернется пустая строка
*/

// создаём форму с указанным значением
var dialogForm = new System.Windows.Forms.Form
{
	Size = new Size(450, 110), ShowIcon = false, Name = "DialogForm", Text = @"Сообщение",
	FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false
};

// поле ввода
var textBox = new System.Windows.Forms.TextBox { Name = "InputText", Size = new Size(410, 20) };

// кладём на форму
dialogForm.Controls.Add(textBox);

// положение на форме
textBox.Location = new Point(12, 12);

// кнопка ОК
var okButton = new System.Windows.Forms.Button { Name = "OKButton", Text = @"OK", Size = new Size(75, 23) };

// кладём на форму
dialogForm.Controls.Add(okButton);

// положение на форме
okButton.Location = new Point(269, 38);

// обработка события
okButton.Click += (delegate { dialogForm.DialogResult = System.Windows.Forms.DialogResult.OK; });

// кнопка отмены
var cancelButton = new System.Windows.Forms.Button { Name = "CancelButton", Text = @"Отмена", Size = new Size(75, 23)};

// кладём на форму
dialogForm.Controls.Add(cancelButton);

// положение на форме
cancelButton.Location = new Point(347, 38);

// обработка события
cancelButton.Click += (delegate { dialogForm.DialogResult = System.Windows.Forms.DialogResult.Cancel; });

// показывем форму
var dialogResult = dialogForm.ShowDialog();

// если не было отмены диалога
if (dialogResult != System.Windows.Forms.DialogResult.Cancel) return textBox.Text;

return String.Empty;
// ОКНО С ДИАЛОГОМ "ДА" ИЛИ "НЕТ" С АВТОЗАКРЫТИЕМ

// создаём форму с указанным значением
var dialogForm = new System.Windows.Forms.Form
{
	Size = new Size(450, 110), ShowIcon = false, Name = "DialogForm", Text = @"Заголовок",
	FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false
};

System.Threading.Thread thread = null;

dialogForm.Shown += (
delegate
{
	thread = new System.Threading.Thread(() =>
	{
		System.Threading.Thread.Sleep(10000); // здесь установка времени в мс; 1 с = 1000 мс
		dialogForm.DialogResult = System.Windows.Forms.DialogResult.Yes; // здесь то что нужно нажать
	});
	thread.Start();
});
 
// поле сообщения
var label = new System.Windows.Forms.Label { Name = "InputText", Size = new Size(410, 20), Text = "Сообщение .............................."};

// кладём не форму
dialogForm.Controls.Add(label);

// положение на форме
label.Location = new Point(12, 12);

// кнопка отмены
var okButton = new System.Windows.Forms.Button { Name = "OKButton", Text = @"Да", Size = new Size(75, 23) };

// кладём не форму
dialogForm.Controls.Add(okButton);

// положение на форме
okButton.Location = new Point(269, 38);

// обработка события
okButton.Click += (delegate { dialogForm.DialogResult = System.Windows.Forms.DialogResult.Yes; });

// кнопка отмены
var cancelButton = new System.Windows.Forms.Button { Name = "CancelButton", Text = @"Нет", Size = new Size(75, 23)};

// кладём не форму
dialogForm.Controls.Add(cancelButton);

// положение на форме
cancelButton.Location = new Point(347, 38);

// обработка события
cancelButton.Click += (delegate { dialogForm.DialogResult = System.Windows.Forms.DialogResult.No; });

// показывем форму
var dialogResult = dialogForm.ShowDialog();
try
{
	thread.Abort();
}
catch(Exception)
{
	
}

// если не было отмены диалога
if (dialogResult == System.Windows.Forms.DialogResult.Yes) return 1;
return 0;
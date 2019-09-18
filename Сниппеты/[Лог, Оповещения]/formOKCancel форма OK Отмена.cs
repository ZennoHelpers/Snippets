//окно с вводом текста и кнопкой ОК 
var dialogForm = new System.Windows.Forms.Form { Size = new Size(300, 200), ShowIcon = false, Name = "DialogForm", Text = @"Тупо текст",
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false };

var groupBox1 = new System.Windows.Forms.GroupBox { Name = "groupBox1", Text = "Вводим код СМС", Size = new Size(120, 130) };
dialogForm.Controls.Add(groupBox1);
groupBox1.Location = new Point (12, 12);
var textBox1 = new System.Windows.Forms.TextBox { Name = "InputText", Size = new Size(100, 15) };
textBox1.Location = new Point(12, 17);
groupBox1.Controls.AddRange( new System.Windows.Forms.Control[] { textBox1 });
var okButton = new System.Windows.Forms.Button { Name = "OKButton", Text = @"OK", Size = new Size(100, 23) };
dialogForm.Controls.Add(okButton);
dialogForm.AcceptButton = okButton;
okButton.Location = new Point(140, 120);
okButton.Click += (delegate
{
    project.Variables["answer"].Value = textBox1.Text;
    dialogForm.DialogResult = System.Windows.Forms.DialogResult.OK;
});
var dialogResult = dialogForm.ShowDialog(); 

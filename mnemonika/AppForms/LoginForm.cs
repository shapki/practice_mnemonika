using mnemonika.AppModules;
using System;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetTitle("Авторизация");
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new Entities())
            {
                var user = context.User
                    .Where(s => s.Login == loginTextBox.Text
                    && s.Password == passwordTextBox.Text)
                    .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var user = context.User
                    .Where(s => s.Login == "g"
                    && s.Password == "g")
                    .FirstOrDefault();

                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}

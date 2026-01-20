using mnemonika.AppModules;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            HideLogoutButton();
        }

        private void HideLogoutButton()
        {
            logoutButton.Visible = false;
        }

        public void ShowLogoutButton()
        {
            logoutButton.Visible = true;
        }

        private void logoutButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            var loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
            loginForm.Show();

            if (this is MainForm mainForm)
            {
                mainForm.ClearUserData();
            }
        }

        /// <summary>
        /// PKGH
        /// Установка текста с ФИО и ролью текущего пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        public void SetFullNameAndRole(User user)
        {
            this.roleLabel.Text = user.Role?.Role1 ?? "Неизвестная роль";
            this.fullNameLabel.Text = user.FullName;
        }

        /// <summary>
        /// PKGH
        /// Установка заголовка окна и в форме
        /// </summary>
        /// <param name="title">Текст заголовка</param>
        public void SetTitle(string title)
        {
            string tempTitle = "\"Мнемоника\": " + title;
            this.Text = tempTitle;
            this.titleLabel.Text = title;
        }
    }
}

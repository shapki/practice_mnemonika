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

        }

        public void SetFullNameAndRole()
        {
            this.roleLabel.Text = "Роль_temp";
            this.fullNameLabel.Text = "Пользователь_temp";
        }

        public void SetTitle(string title)
        {
            string tempTitle = "\"Мнемоника\": " + title;
            this.Text = tempTitle;
            this.titleLabel.Text = title;
        }
    }
}

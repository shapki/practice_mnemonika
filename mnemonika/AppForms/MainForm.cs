using mnemonika.AppControls;
using mnemonika.AppModules;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppForms
{
    public partial class MainForm : ParentForm
    {
        private User currentUser;
        private Entities context;

        public MainForm(User user)
        {
            InitializeComponent();
            ShowLogoutButton();
            SetTitle("Карточки");
            SetFullNameAndRole(user);

            currentUser = user;
            context = new Entities();

            LoadCards();
        }

        private void LoadCards()
        {
            flowLayoutPanel1.Controls.Clear();

            IQueryable<Word> query = context.Word.Include("Auxi").Include("Difficulty");

            if (currentUser.RoleId == 3 || currentUser.RoleId == 4)
            {
                query = query.Where(w => w.UserId == currentUser.IdUser);
            }

            var words = query.ToList();

            foreach (var word in words)
            {
                CardControl cardControl = new CardControl();
                cardControl.SetWordData(word);
                flowLayoutPanel1.Controls.Add(cardControl);
            }
        }

        public void ClearUserData()
        {
            currentUser = null;
            context?.Dispose();
            context = null;

            this.roleLabel.Text = "";
            this.fullNameLabel.Text = "";
            flowLayoutPanel1.Controls.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
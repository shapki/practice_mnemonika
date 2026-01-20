using mnemonika.AppControls;
using mnemonika.AppModules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        /// <summary>
        /// PKGH
        /// Загрузка карточек
        /// </summary>
        private void LoadCards()
        {
            flowLayoutPanel1.Controls.Clear();

            IQueryable<Word> query = context.Word.Include("Auxi").Include("Difficulty");

            if (currentUser.RoleId == 3 || currentUser.RoleId == 4)
            {
                query = query.Where(w => w.UserId == currentUser.IdUser || w.GeneralCardMark == true);
            }

            var words = query.ToList();

            foreach (var word in words)
            {
                CardControl cardControl = new CardControl();
                cardControl.SetWordData(word, currentUser.IdUser, currentUser.RoleId);
                cardControl.CardUpdated += CardControl_CardUpdated;
                flowLayoutPanel1.Controls.Add(cardControl);
            }
        }

        private void CardControl_CardUpdated(object sender, EventArgs e)
        {
            Refresh();
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

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_mnemonikaDataSet.PartOfSpeech". При необходимости она может быть перемещена или удалена.
            this.partOfSpeechTableAdapter.Fill(this.shapkin_mnemonikaDataSet.PartOfSpeech);

            FillPartOfSpeech();

            if (currentUser.RoleId == 4)
            {
                searchTextBox.Visible = false;
                searchLabel.Visible = false;
                partOfSpeechComboBox.Visible = false;
                partOfSpeechLabel.Visible = false;
                addButton.Visible = false;
            }
        }

        /// <summary>
        /// PKGH
        /// Заполнение фильтра частей речи
        /// </summary>
        private void FillPartOfSpeech()
        {
            using (var context = new Entities())
            {
                List<PartOfSpeech> partOfSpeeches = context.PartOfSpeech.OrderBy(s => s.PartOfSpeech1).ToList();

                PartOfSpeech allPartOfSpeech = new PartOfSpeech();
                allPartOfSpeech.PartOfSpeech1 = "Все части речи";
                allPartOfSpeech.IdPartOfSpeech = 0;
                partOfSpeeches.Insert(0, allPartOfSpeech);

                partOfSpeechBindingSource.DataSource = partOfSpeeches;
                partOfSpeechComboBox.DisplayMember = "PartOfSpeech1";
                partOfSpeechComboBox.ValueMember = "IdPartOfSpeech";
            }
        }

        private int GetPartOfSpeechId()
        {
            if (partOfSpeechComboBox.SelectedItem != null && partOfSpeechComboBox.SelectedValue != null)
            {
                int selectedId = (int)partOfSpeechComboBox.SelectedValue;
                return selectedId;
            }
            return 0;
        }

        private void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void partOfSpeechComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            LoadCards();
            SelectCards();
        }

        /// <summary>
        /// PKGH
        /// Выборка карточек с применением фильтров и поиска
        /// </summary>
        private void SelectCards()
        {
            string searchInput = searchTextBox.Text.Trim();
            int partOfSpeechId = GetPartOfSpeechId();

            IQueryable<Word> query = context.Word.Include(w => w.Auxi).Include(w => w.Difficulty);

            if (currentUser.RoleId == 3 || currentUser.RoleId == 4)
            {
                query = query.Where(w => w.UserId == currentUser.IdUser || w.GeneralCardMark == true);
            }

            if (!String.IsNullOrEmpty(searchInput))
            {
                query = query.Where(w =>
                    DbFunctions.Like(w.Auxi.RusWord, "%" + searchInput + "%") ||
                    DbFunctions.Like(w.Hint, "%" + searchInput + "%") ||
                    w.Auxi.Mnemonic.Any(m => DbFunctions.Like(m.MnemonicDevice, "%" + searchInput + "%"))
                );
            }

            if (partOfSpeechId > 0)
            {
                query = query.Where(w => w.PartOfSpeechId == partOfSpeechId);
            }

            flowLayoutPanel1.Controls.Clear();

            var words = query.ToList();
            foreach (var word in words)
            {
                CardControl cardControl = new CardControl();
                cardControl.SetWordData(word, currentUser.IdUser, currentUser.RoleId);
                flowLayoutPanel1.Controls.Add(cardControl);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateUpdateCardForm CreateUpdateCardForm = new CreateUpdateCardForm();
            DialogResult saved = CreateUpdateCardForm.ShowDialog();
        }

        public int CurrentUserId
        {
            get { return currentUser?.IdUser ?? 0; }
        }

        public int CurrentUserRoleId
        {
            get { return currentUser?.RoleId ?? 0; }
        }
    }
}
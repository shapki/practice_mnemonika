using mnemonika.AppModules;
using System;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppForms
{
    public partial class CreateUpdateMnemonicForm : ParentForm
    {
        private int auxId;
        private bool isEditMode = false;
        private Mnemonic currentMnemonic;

        public CreateUpdateMnemonicForm(int auxId, bool hasExistingMnemonic)
        {
            InitializeComponent();
            ShowLogoutButton();

            this.auxId = auxId;
            this.isEditMode = hasExistingMnemonic;

            if (isEditMode)
            {
                SetTitle("Редактирование мнемоника");
                LoadMnemonicData();
            }
            else
            {
                SetTitle("Добавление мнемоника");
            }
        }

        private void CreateUpdateMnemonicForm_Load(object sender, EventArgs e)
        {
            LoadMnemonicList();

            using (var context = new Entities())
            {
                var aux = context.Auxi.FirstOrDefault(a => a.IdAux == auxId);
                if (aux != null)
                {
                    wordInfoLabel.Text = $"Слово: {aux.RusWord} ({aux.EngWord})";
                }
            }
        }

        /// <summary>
        /// PKGH
        /// Список слов/фраз и их мнемоников
        /// </summary>
        private void LoadMnemonicList()
        {
            using (var context = new Entities())
            {
                var mnemonics = context.Mnemonic
                    .Include("Auxi")
                    .OrderBy(m => m.IdMnemonic)
                    .ToList();

                mnemonicListBox.Items.Clear();

                foreach (var mnemonic in mnemonics)
                {
                    string russianWord = mnemonic.Auxi?.RusWord ?? "неизвестно";

                    string displayText = $"{russianWord}: {mnemonic.MnemonicDevice}";

                    mnemonicListBox.Items.Add(displayText);
                }
            }
        }

        private void LoadMnemonicData()
        {
            using (var context = new Entities())
            {
                currentMnemonic = context.Mnemonic.FirstOrDefault(m => m.AuxId == auxId);
                if (currentMnemonic != null)
                {
                    mnemonicDeviceTextBox.Text = currentMnemonic.MnemonicDevice;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mnemonicDeviceTextBox.Text))
            {
                MessageBox.Show("Введите мнемоническое устройство", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new Entities())
                {
                    if (isEditMode)
                    {
                        var mnemonicInDb = context.Mnemonic.FirstOrDefault(m => m.AuxId == auxId);
                        if (mnemonicInDb != null)
                        {
                            mnemonicInDb.MnemonicDevice = mnemonicDeviceTextBox.Text.Trim();
                        }
                    }
                    else
                    {
                        var newMnemonic = new Mnemonic
                        {
                            AuxId = auxId,
                            MnemonicDevice = mnemonicDeviceTextBox.Text.Trim()
                        };
                        context.Mnemonic.Add(newMnemonic);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Мнемоник успешно сохранен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить этот мнемоник?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new Entities())
                    {
                        var mnemonicToDelete = context.Mnemonic.FirstOrDefault(m => m.AuxId == auxId);
                        if (mnemonicToDelete != null)
                        {
                            context.Mnemonic.Remove(mnemonicToDelete);
                            context.SaveChanges();
                            MessageBox.Show("Мнемоник успешно удален", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
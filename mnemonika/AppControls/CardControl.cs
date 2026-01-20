using mnemonika.AppConstants;
using mnemonika.AppForms;
using mnemonika.AppModules;
using mnemonika.AppServices;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppControls
{
    public partial class CardControl : UserControl
    {
        public event EventHandler CardUpdated;
        private Word currentWord;
        private bool isDetailedView = false;
        private bool isHintVisible = false;
        private bool hasHint = false;
        private bool hasMnemonic = false;
        private static CardControl currentlyOpenCard = null;
        private int currentUserId = 0;
        private int currentUserRoleId = 0;

        public CardControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PKGH Установка данных о слове/фразе (карточке)
        /// </summary>
        /// <param name="word">Слово/фраза</param>
        /// <param name="userId">Текущий пользователь</param>
        /// <param name="userRoleId">Роль текущего пользователя</param>
        public void SetWordData(Word word, int userId, int userRoleId)
        {
            currentWord = word;
            currentUserId = userId;
            currentUserRoleId = userRoleId;
            CheckMnemonicAndHint();
            UpdateCardDisplay();
            UpdateElementsVisibilityByRole();
        }

        private void UpdateElementsVisibilityByRole()
        {
            bool canEdit = (currentUserRoleId == 1 || currentUserRoleId == 2) ||
                       (currentWord?.UserId == currentUserId);

            editButton.Visible = canEdit;

            bool canEditMnemonic = (currentUserRoleId == 1 || currentUserRoleId == 2) ||
                                  (currentWord?.UserId == currentUserId) ||
                                  (currentWord?.GeneralCardMark == true);

            editMnemonicButton.Visible = canEditMnemonic && !(currentUserRoleId == 4);

            UpdateMnemonicButtonText();
        }

        private void UpdateMnemonicButtonText()
        {
            if (hasMnemonic)
            {
                editMnemonicButton.Text = "ред. мнемоник";
            }
            else
            {
                editMnemonicButton.Text = "доб. мнемоник";
            }
        }

        private void CheckMnemonicAndHint()
        {
            if (currentWord?.AuxId == null) return;

            using (var context = new Entities())
            {
                hasHint = !string.IsNullOrEmpty(currentWord.Hint);
                hasMnemonic = context.Mnemonic.Any(m => m.AuxId == currentWord.AuxId);
            }
        }

        private void UpdateCardDisplay()
        {
            if (currentWord == null) return;

            if (currentWord.DifficultyId.HasValue)
            {
                levelLabel.Text = currentWord.Difficulty?.Difficulty1 ?? "";
                UpdateCardColor();
            }

            studyDateLabel.Text = GetStudyDateText();
            WordLabel.Text = currentWord.Auxi?.RusWord ?? "";
            nounLabel.Text = currentWord.PartOfSpeech?.PartOfSpeech1 ?? "";

            hintButton.Visible = hasHint;
            mnemonicButton.Visible = hasMnemonic && !(currentUserRoleId == 4);
        }

        private string GetStudyDateText()
        {
            return currentWord.StudyDate.HasValue
                ? currentWord.StudyDate.Value.ToString("dd.MM.yyyy")
                : "Не изучено";
        }

        /// <summary>
        /// PKGH
        /// Переключение отображения карточки
        /// </summary>
        public void ToggleView()
        {
            if (currentlyOpenCard != null && currentlyOpenCard != this && currentlyOpenCard.isDetailedView)
            {
                currentlyOpenCard.isDetailedView = false;
                currentlyOpenCard.UpdateView();
            }

            isDetailedView = !isDetailedView;
            UpdateView();

            if (isDetailedView)
            {
                currentlyOpenCard = this;
                UpdateStudyDate();
            }
            else if (currentlyOpenCard == this)
            {
                currentlyOpenCard = null;
            }
        }

        private void UpdateStudyDate()
        {
            if (currentWord == null) return;

            try
            {
                using (var context = new Entities())
                {
                    var wordInDb = context.Word.FirstOrDefault(w => w.IdWord == currentWord.IdWord);
                    if (wordInDb != null)
                    {
                        wordInDb.StudyDate = DateTime.Now.Date;
                        context.SaveChanges();

                        currentWord.StudyDate = wordInDb.StudyDate;

                        studyDateLabel.Text = GetStudyDateText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении даты изучения: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateView()
        {
            if (isDetailedView)
            {
                ShowDetailedView();
            }
            else
            {
                ShowNormalView();
            }
        }

        private void ShowNormalView()
        {
            if (currentlyOpenCard == this)
            {
                currentlyOpenCard = null;
            }

            SetPanel1Visibility(false);
            SetPanel2Visibility(true);
            UpdateNormalViewContent();
        }

        private void ShowDetailedView()
        {
            if (currentWord == null) return;

            SetPanel1Visibility(true);
            SetPanel2Visibility(false);
            UpdateDetailedViewContent();
        }

        private void SetPanel1Visibility(bool showPicture)
        {
            pictureBox.Visible = showPicture;
            label1.Visible = !showPicture;
            nounLabel.Visible = !showPicture;
            levelLabel.Visible = !showPicture;
        }

        private void SetPanel2Visibility(bool isNormalView)
        {
            hintButton.Visible = isNormalView && hasHint;
            hintLabel.Visible = isNormalView && isHintVisible && hasHint;
            mnemonicButton.Visible = isNormalView && hasMnemonic;

            sentence1Label.Visible = !isNormalView;
            sentence2Label.Visible = !isNormalView;
            errorTranslationLabel.Visible = !isNormalView && !string.IsNullOrEmpty(currentWord?.Auxi?.TipicalMistake);
        }

        private void UpdateNormalViewContent()
        {
            studyDateLabel.ForeColor = Color.Black;
            studyDateLabel.Text = GetStudyDateText();
            WordLabel.Text = currentWord?.Auxi?.RusWord ?? "";
        }

        private void UpdateDetailedViewContent()
        {
            studyDateLabel.Text = currentWord.Auxi?.EngWord ?? "";
            UpdateTranscription();
            UpdateExamples();
            UpdateImage();
            UpdateTypicalMistake();
        }

        private void UpdateTranscription()
        {
            var aux = currentWord.Auxi;
            string britishTrans = !string.IsNullOrEmpty(aux?.BritishTrans) ? $"Br: {aux.BritishTrans}" : "";
            string americanTrans = !string.IsNullOrEmpty(aux?.NorthAmericanTrans) ? $"Am: {aux.NorthAmericanTrans}" : "";
            WordLabel.Text = $"{britishTrans}\n{americanTrans}".Trim();
        }

        private void UpdateExamples()
        {
            using (var context = new Entities())
            {
                var examples = context.Word
                    .Where(w => w.AuxId == currentWord.AuxId && !string.IsNullOrEmpty(w.Example))
                    .Select(w => w.Example)
                    .Take(2)
                    .ToList();

                sentence1Label.Text = examples.Count > 0 ? examples[0] : "";
                sentence2Label.Text = examples.Count > 1 ? examples[1] : "";
            }
        }

        private void UpdateImage()
        {
            try
            {
                var imagePath = FileManager.GetImgPath(currentWord.Auxi?.Photo);
                pictureBox.Image = new Bitmap(Image.FromFile(imagePath));
            }
            catch (FileNotFoundException)
            {
                pictureBox.Image = Image.FromFile(FileManager.GetImgPath(FilePath.defaultPicture));
            }
        }

        private void UpdateTypicalMistake()
        {
            var mistake = currentWord.Auxi?.TipicalMistake;
            if (!string.IsNullOrEmpty(mistake))
            {
                studyDateLabel.ForeColor = Color.Red;
                errorTranslationLabel.Text = mistake;
            }
            else
            {
                studyDateLabel.ForeColor = Color.Black;
            }
        }

        private void UpdateCardColor()
        {
            if (hardRadioButton.Checked)
            {
                this.BackColor = Color.FromArgb(255, 60, 0);
            }
            else if (currentWord.Difficulty?.Difficulty1?.StartsWith("C") == true)
            {
                this.BackColor = Color.FromArgb(0, 149, 255);
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void CardControl_Click(object sender, EventArgs e) => ToggleView();
        private void elements_Click(object sender, EventArgs e) => ToggleView();
        private void RadioButton_CheckedChanged(object sender, EventArgs e) => UpdateCardColor();

        private void hintButton_Click(object sender, EventArgs e)
        {
            isHintVisible = !isHintVisible;

            if (hasHint)
            {
                hintLabel.Visible = isHintVisible;
                hintLabel.Text = currentWord.Hint;
            }
        }

        private void mnemonicButton_Click(object sender, EventArgs e)
        {
            string mnemonic;
            using (var context = new Entities())
            {
                mnemonic = context.Mnemonic
                    .Where(m => m.AuxId == currentWord.AuxId)
                    .Select(m => m.MnemonicDevice)
                    .FirstOrDefault() ?? "";
            }
            MessageBox.Show(mnemonic, "Мнемоник", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CreateUpdateCardForm createUpdateCardForm = new CreateUpdateCardForm(currentWord);
            DialogResult wordSaved = createUpdateCardForm.ShowDialog();

            if (wordSaved == DialogResult.OK)
            {
                CardUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// PKGH
        /// Добавление/редактирование мнемоника
        /// </summary>
        private void editMnemonicButton_Click(object sender, EventArgs e)
        {
            if (currentWord == null || currentWord.AuxId == null) return;

            bool canEditMnemonic = (currentUserRoleId == 1 || currentUserRoleId == 2) ||
                                  (currentWord?.UserId == currentUserId) ||
                                  (currentWord?.GeneralCardMark == true);

            if (!canEditMnemonic)
            {
                MessageBox.Show("Вы не можете редактировать мнемоник для этой карточки",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateUpdateMnemonicForm mnemonicForm = new CreateUpdateMnemonicForm(currentWord.AuxId, hasMnemonic);
            DialogResult result = mnemonicForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                CheckMnemonicAndHint();
                UpdateMnemonicButtonText();
                mnemonicButton.Visible = hasMnemonic && !(currentUserRoleId == 4);

                CardUpdated?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
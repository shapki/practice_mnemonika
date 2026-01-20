using mnemonika.AppModules;
using mnemonika.AppServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace mnemonika.AppForms
{
    public partial class CreateUpdateCardForm : ParentForm
    {
        private Word currentWord;
        private bool isEditMode = false;

        /// <summary>
        /// PKGH
        /// Новая карточка
        /// </summary>
        public CreateUpdateCardForm()
        {
            InitializeComponent();
            ShowLogoutButton();
            SetTitle("Добавление карточки");
            currentWord = new Word();
            isEditMode = false;
        }

        /// <summary>
        /// PKGH
        /// Редактирование карточки
        /// </summary>
        /// <param name="word">Слово/фраза</param>
        public CreateUpdateCardForm(Word word)
        {
            InitializeComponent();
            ShowLogoutButton();
            SetTitle("Редактирование карточки");
            currentWord = word;
            isEditMode = true;
            LoadWordData();
        }

        private void CreateUpdateCardForm_Load(object sender, EventArgs e)
        {
            this.partOfSpeechTableAdapter.Fill(this.shapkin_mnemonikaDataSet.PartOfSpeech);
            this.themeTableAdapter.Fill(this.shapkin_mnemonikaDataSet.Theme);
            this.auxiTableAdapter.Fill(this.shapkin_mnemonikaDataSet.Auxi);
            this.difficultyTableAdapter.Fill(this.shapkin_mnemonikaDataSet.Difficulty);

            FillForm();
        }

        /// <summary>
        /// PKGH
        /// Заполнение формы данными
        /// </summary>
        private void FillForm()
        {
            partOfSpeechIdComboBox.SelectedValue = currentWord.PartOfSpeechId;
            themeIdComboBox.SelectedValue = currentWord.ThemeId;
            //studyDateDateTimePicker.Value = currentWord.StudyDate.Value;
            auxIdComboBox.SelectedValue = currentWord.AuxId;
            if (auxIdComboBox.SelectedValue != null)
            {
                auxIdComboBox_SelectedIndexChanged(auxIdComboBox, EventArgs.Empty);
            }
            tipicalMistakeTextBox.Text = currentWord.Auxi?.TipicalMistake;
            britishTransTextBox.Text = currentWord.Auxi?.BritishTrans;
            northAmericanTransTextBox.Text = currentWord.Auxi?.NorthAmericanTrans;
            photoTextBox.Text = currentWord.Auxi?.Photo;
            //difficultyIdComboBox.SelectedValue = currentWord.DifficultyId;
            exampleTextBox.Text = currentWord.Example;
            hintTextBox.Text = currentWord.Hint;
            basicExampleMarkCheckBox.Checked = currentWord.BasicExampleMark;
            generalCardMarkCheckBox.Checked = currentWord.GeneralCardMark;
        }

        private void LoadWordData()
        {
            if (currentWord != null && currentWord.IdWord > 0)
            {
                using (var context = new Entities())
                {
                    currentWord = context.Word
                        .Include("Auxi")
                        .Include("PartOfSpeech")
                        .Include("Theme")
                        .Include("Difficulty")
                        .FirstOrDefault(w => w.IdWord == currentWord.IdWord);

                    if (currentWord != null)
                    {
                        wordBindingSource.DataSource = currentWord;
                        auxiBindingSource.DataSource = currentWord.Auxi;

                        partOfSpeechIdComboBox.SelectedValue = currentWord.PartOfSpeechId;
                        themeIdComboBox.SelectedValue = currentWord.ThemeId;
                        auxIdComboBox.SelectedValue = currentWord.AuxId;
                        if (currentWord.DifficultyId.HasValue)
                        {
                            difficultyIdComboBox.SelectedValue = currentWord.DifficultyId.Value;
                        }

                        if (currentWord.StudyDate.HasValue)
                        {
                            studyDateDateTimePicker.Value = currentWord.StudyDate.Value;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// PKGH
        /// Заполнение модели слов/фраз
        /// </summary>
        private void FillWordModel()
        {
            if (currentWord == null)
                currentWord = new Word();

            currentWord.PartOfSpeechId = (int)partOfSpeechIdComboBox.SelectedValue;
            currentWord.ThemeId = (int)themeIdComboBox.SelectedValue;
            currentWord.AuxId = (int)auxIdComboBox.SelectedValue;

            if (studyDateDateTimePicker.Checked)
            {
                currentWord.StudyDate = studyDateDateTimePicker.Value;
            }
            else
            {
                currentWord.StudyDate = null;
            }

            if (difficultyIdComboBox.SelectedItem != null)
            {
                currentWord.DifficultyId = (int)difficultyIdComboBox.SelectedValue;
            }
            else
            {
                currentWord.DifficultyId = null;
            }

            currentWord.Example = exampleTextBox.Text;
            currentWord.Hint = hintTextBox.Text;
            currentWord.BasicExampleMark = basicExampleMarkCheckBox.Checked;
            currentWord.GeneralCardMark = generalCardMarkCheckBox.Checked;

            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                currentWord.UserId = mainForm.CurrentUserId;
            }
        }

        private void FillAuxiModel()
        {
            var selectedAux = auxIdComboBox.SelectedItem as Auxi;
            if (selectedAux != null)
            {
                selectedAux.TipicalMistake = tipicalMistakeTextBox.Text;
                selectedAux.BritishTrans = britishTransTextBox.Text;
                selectedAux.NorthAmericanTrans = northAmericanTransTextBox.Text;

                if (!string.IsNullOrEmpty(photoTextBox.Text))
                {
                    if (isEditMode && !string.IsNullOrEmpty(selectedAux.Photo))
                    {
                        DeleteOldPhoto(selectedAux.Photo);
                    }

                    string newFileName = SaveImage();
                    if (!string.IsNullOrEmpty(newFileName))
                    {
                        selectedAux.Photo = newFileName;
                        photoTextBox.Text = newFileName;
                    }
                }
            }
        }

        /// <summary>
        /// PKGH
        /// Старый файл удаляем.
        /// Ситуация возможна в случае изменения товара.
        /// </summary>
        private void DeleteOldPhoto(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                FileManager.DeleteFile(fileName);
            }
        }

        /// <summary>
        /// PKGH
        /// Сохранение изображения товара
        /// </summary>
        /// <returns></returns>
        private string SaveImage()
        {
            if (string.IsNullOrEmpty(openFileDialog1.FileName) || openFileDialog1.FileName == "openFileDialog1")
            {
                return photoTextBox.Text;
            }

            try
            {
                Image originalImage = Image.FromFile(openFileDialog1.FileName);
                Dictionary<string, int> newImageSize = GetNewImageSize(originalImage);

                Bitmap resizedImage = new Bitmap(originalImage, newImageSize["width"], newImageSize["height"]);

                string fileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg";

                string savePath = FileManager.GetImgPath(fileName);

                resizedImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                originalImage.Dispose();
                resizedImage.Dispose();

                return fileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        /// <summary>
        /// PKGH
        /// Файл будет сохраняться с размером не более 300 х 200.
        /// Получить размеры нового файла.
        /// </summary>
        /// <param name="originalImage"></param>
        /// <returns></returns>
        private Dictionary<string, int> GetNewImageSize(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Dictionary<string, int> result = new Dictionary<string, int>
            {
                { "width", newWidth },
                { "height", newHeight }
            };

            return result;
        }

        private bool ValidateFields()
        {
            if (partOfSpeechIdComboBox.SelectedItem == null || partOfSpeechIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите часть речи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (themeIdComboBox.SelectedItem == null || themeIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите тему", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (auxIdComboBox.SelectedItem == null || auxIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите слово/фразу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                FillWordModel();
                FillAuxiModel();

                var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                using (var context = new Entities())
                {
                    if (isEditMode)
                    {
                        var existingWord = context.Word
                            .Include("Auxi")
                            .FirstOrDefault(w => w.IdWord == currentWord.IdWord);

                        if (existingWord != null)
                        {
                            existingWord.PartOfSpeechId = currentWord.PartOfSpeechId;
                            existingWord.ThemeId = currentWord.ThemeId;
                            existingWord.AuxId = currentWord.AuxId;
                            existingWord.StudyDate = currentWord.StudyDate;
                            existingWord.DifficultyId = currentWord.DifficultyId;
                            existingWord.Example = currentWord.Example;
                            existingWord.Hint = currentWord.Hint;
                            existingWord.BasicExampleMark = currentWord.BasicExampleMark;
                            existingWord.GeneralCardMark = currentWord.GeneralCardMark;

                            var auxi = context.Auxi.FirstOrDefault(a => a.IdAux == currentWord.AuxId);
                            if (auxi != null)
                            {
                                auxi.TipicalMistake = tipicalMistakeTextBox.Text;
                                auxi.BritishTrans = britishTransTextBox.Text;
                                auxi.NorthAmericanTrans = northAmericanTransTextBox.Text;
                                auxi.Photo = photoTextBox.Text;
                            }
                        }
                    }
                    else
                    {
                        var selectedAux = context.Auxi.FirstOrDefault(a => a.IdAux == currentWord.AuxId);
                        if (selectedAux != null)
                        {
                            selectedAux.TipicalMistake = tipicalMistakeTextBox.Text;
                            selectedAux.BritishTrans = britishTransTextBox.Text;
                            selectedAux.NorthAmericanTrans = northAmericanTransTextBox.Text;
                            selectedAux.Photo = photoTextBox.Text;
                        }
                        currentWord.UserId = mainForm.CurrentUserId;

                        context.Word.Add(currentWord);
                    }

                    context.SaveChanges();
                    mainForm.Refresh();
                    MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения (*.jpg;*.jpeg)|*.jpg;*.jpeg";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                photoTextBox.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// PKGH
        /// Подстановка транскрипций и фото в зависимости от выбранного слова/фразы
        /// </summary>
        private void auxIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auxIdComboBox.SelectedItem is Auxi selectedAux)
            {
                tipicalMistakeTextBox.Text = selectedAux.TipicalMistake ?? "";
                britishTransTextBox.Text = selectedAux.BritishTrans ?? "";
                northAmericanTransTextBox.Text = selectedAux.NorthAmericanTrans ?? "";
                photoTextBox.Text = selectedAux.Photo ?? "";
            }
            else if (auxIdComboBox.SelectedValue != null)
            {
                int selectedAuxId;
                if (int.TryParse(auxIdComboBox.SelectedValue.ToString(), out selectedAuxId))
                {
                    using (var context = new Entities())
                    {
                        var aux = context.Auxi.FirstOrDefault(a => a.IdAux == selectedAuxId);
                        if (aux != null)
                        {
                            tipicalMistakeTextBox.Text = aux.TipicalMistake ?? "";
                            britishTransTextBox.Text = aux.BritishTrans ?? "";
                            northAmericanTransTextBox.Text = aux.NorthAmericanTrans ?? "";
                            photoTextBox.Text = aux.Photo ?? "";
                        }
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            int currentUserId = mainForm.CurrentUserId;

            using (var context = new Entities())
            {
                var wordToDelete = context.Word
                    .Include("Auxi")
                    .FirstOrDefault(w => w.IdWord == currentWord.IdWord);

                if (wordToDelete == null)
                {
                    MessageBox.Show("Карточка не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mainForm.CurrentUserRoleId > 2 && wordToDelete.UserId != currentUserId)
                {
                    MessageBox.Show("Вы можете удалять только свои карточки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool hasMnemonic = context.Mnemonic.Any(m => m.AuxId == wordToDelete.AuxId);

                if (hasMnemonic)
                {
                    var auxInfo = context.Auxi.FirstOrDefault(a => a.IdAux == wordToDelete.AuxId);
                    string wordInfo = auxInfo != null ? $"{auxInfo.RusWord} ({auxInfo.EngWord})" : "этого слова";

                    MessageBox.Show($"Невозможно удалить карточку, так как для слова \"{wordInfo}\" существует мнемоник.\n" +
                                  "Сначала удалите мнемоник через соответствующую кнопку на карточке.",
                                  "Ошибка удаления",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту карточку?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // PKGH: удаление фото у последнего Aux
                        var otherCardsWithSameAux = context.Word
                            .Where(w => w.AuxId == wordToDelete.AuxId && w.IdWord != wordToDelete.IdWord)
                            .ToList();

                        if (otherCardsWithSameAux.Count == 0 && !string.IsNullOrEmpty(wordToDelete.Auxi?.Photo))
                        {
                            FileManager.DeleteFile(wordToDelete.Auxi.Photo);
                        }

                        context.Word.Remove(wordToDelete);
                        context.SaveChanges();

                        mainForm.Refresh();

                        MessageBox.Show("Карточка успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении карточки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

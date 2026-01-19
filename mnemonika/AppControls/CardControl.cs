using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using mnemonika.AppModules;

namespace mnemonika.AppControls
{
    public partial class CardControl : UserControl
    {
        private Word currentWord;
        private bool isDetailedView = false;

        public CardControl()
        {
            InitializeComponent();
        }

        public void SetWordData(Word word)
        {
            currentWord = word;
            UpdateCardDisplay();
        }

        private void UpdateCardDisplay()
        {
            if (currentWord == null) return;

            if (currentWord.DifficultyId.HasValue)
            {
                levelLabel.Text = currentWord.Difficulty?.Difficulty1 ?? "";

                if (currentWord.Difficulty.Difficulty1.StartsWith("C"))
                {
                    this.BackColor = Color.FromArgb(0, 149, 255);
                }
            }

            studyDateLabel.Text = currentWord.StudyDate.HasValue
                ? currentWord.StudyDate.Value.ToString("dd.MM.yyyy")
                : "Не изучено";

            WordLabel.Text = currentWord.Auxi?.EngWord ?? "";

            nounLabel.Text = currentWord.PartOfSpeech?.PartOfSpeech1 ?? "";
        }

        public void ToggleView()
        {
            isDetailedView = !isDetailedView;

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
            pictureBox.Visible = false;
            label1.Visible = true;
            nounLabel.Visible = true;
            levelLabel.Visible = true;
            hintButton.Visible = true;
            hintLabel.Visible = true;
            mnemonicButton.Visible = true;

            errorTranslationLabel.Visible = false;
            sentence1Label.Visible = false;
            sentence2Label.Visible = false;
        }

        private void ShowDetailedView()
        {
            if (currentWord == null) return;

            pictureBox.Visible = !string.IsNullOrEmpty(currentWord.Auxi?.Photo);
            label1.Visible = false;
            nounLabel.Visible = false;
            levelLabel.Visible = false;
            hintButton.Visible = false;
            hintLabel.Visible = false;
            mnemonicButton.Visible = false;

            UpdateDetailedView();
        }

        private void UpdateDetailedView()
        {
            studyDateLabel.Text = currentWord.Auxi?.EngWord ?? "";

            if (!string.IsNullOrEmpty(currentWord.Auxi?.TipicalMistake))
            {
                studyDateLabel.ForeColor = Color.Red;
                errorTranslationLabel.Text = currentWord.Auxi.TipicalMistake;
                errorTranslationLabel.Visible = true;
            }
            else
            {
                studyDateLabel.ForeColor = Color.Black;
                errorTranslationLabel.Visible = false;
            }

            string britishTrans = !string.IsNullOrEmpty(currentWord.Auxi?.BritishTrans)
                ? $"Br: {currentWord.Auxi.BritishTrans}"
                : "";

            string americanTrans = !string.IsNullOrEmpty(currentWord.Auxi?.NorthAmericanTrans)
                ? $"Am: {currentWord.Auxi.NorthAmericanTrans}"
                : "";

            WordLabel.Text = $"{britishTrans}\n{americanTrans}".Trim();

            using (var context = new Entities())
            {
                var examples = context.Word
                    .Where(w => w.AuxId == currentWord.AuxId && !string.IsNullOrEmpty(w.Example))
                    .Select(w => w.Example)
                    .Take(2)
                    .ToList();

                if (examples.Count > 0)
                {
                    sentence1Label.Text = examples[0];
                    sentence1Label.Visible = true;
                }
                else
                {
                    sentence1Label.Visible = false;
                }

                if (examples.Count > 1)
                {
                    sentence2Label.Text = examples[1];
                    sentence2Label.Visible = true;
                }
                else
                {
                    sentence2Label.Visible = false;
                }
            }
        }

        private void CardControl_Click(object sender, EventArgs e)
        {
            ToggleView();
        }

        private void easyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCardColor();
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCardColor();
        }

        private void hardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCardColor();
        }

        private void UpdateCardColor()
        {
            if (hardRadioButton.Checked)
            {
                this.BackColor = Color.FromArgb(255, 60, 0);
            }
            else if (currentWord?.Difficulty?.Difficulty1?.StartsWith("C") == true)
            {
                this.BackColor = Color.FromArgb(0, 149, 255);
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void elements_Click(object sender, EventArgs e)
        {
            ToggleView();
        }

        private void hintButton_Click(object sender, EventArgs e)
        {

        }

        private void mnemonicButton_Click(object sender, EventArgs e)
        {

        }
    }
}
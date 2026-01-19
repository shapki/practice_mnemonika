namespace mnemonika.AppControls
{
    partial class CardControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nounLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.studyDateLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.WordLabel = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.mnemonicButton = new System.Windows.Forms.Button();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.errorTranslationLabel = new System.Windows.Forms.Label();
            this.sentence1Label = new System.Windows.Forms.Label();
            this.sentence2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.levelLabel);
            this.panel1.Controls.Add(this.nounLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 122);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.elements_Click);
            // 
            // nounLabel
            // 
            this.nounLabel.AutoSize = true;
            this.nounLabel.Location = new System.Drawing.Point(3, 42);
            this.nounLabel.Name = "nounLabel";
            this.nounLabel.Size = new System.Drawing.Size(62, 13);
            this.nounLabel.TabIndex = 1;
            this.nounLabel.Text = "Сущ_текст";
            this.nounLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сущ.";
            this.label1.Click += new System.EventHandler(this.elements_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sentence2Label);
            this.panel2.Controls.Add(this.sentence1Label);
            this.panel2.Controls.Add(this.errorTranslationLabel);
            this.panel2.Controls.Add(this.mnemonicButton);
            this.panel2.Controls.Add(this.hintLabel);
            this.panel2.Controls.Add(this.hintButton);
            this.panel2.Controls.Add(this.WordLabel);
            this.panel2.Controls.Add(this.studyDateLabel);
            this.panel2.Location = new System.Drawing.Point(137, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 122);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.elements_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hardRadioButton);
            this.panel3.Controls.Add(this.mediumRadioButton);
            this.panel3.Controls.Add(this.easyRadioButton);
            this.panel3.Controls.Add(this.editButton);
            this.panel3.Location = new System.Drawing.Point(544, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 122);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.elements_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(3, 95);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(51, 13);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "Уровень";
            this.levelLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // studyDateLabel
            // 
            this.studyDateLabel.AutoSize = true;
            this.studyDateLabel.Location = new System.Drawing.Point(3, 1);
            this.studyDateLabel.Name = "studyDateLabel";
            this.studyDateLabel.Size = new System.Drawing.Size(85, 13);
            this.studyDateLabel.TabIndex = 0;
            this.studyDateLabel.Text = "Дата_изучения";
            this.studyDateLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(94, 95);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // WordLabel
            // 
            this.WordLabel.Location = new System.Drawing.Point(3, 29);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(376, 37);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Слово";
            this.WordLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(6, 74);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(75, 23);
            this.hintButton.TabIndex = 2;
            this.hintButton.Text = "Подсказка";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(3, 100);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(63, 13);
            this.hintLabel.TabIndex = 3;
            this.hintLabel.Text = "Подсказка";
            this.hintLabel.Visible = false;
            this.hintLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // mnemonicButton
            // 
            this.mnemonicButton.Location = new System.Drawing.Point(304, 74);
            this.mnemonicButton.Name = "mnemonicButton";
            this.mnemonicButton.Size = new System.Drawing.Size(75, 23);
            this.mnemonicButton.TabIndex = 4;
            this.mnemonicButton.Text = "Мнемоник";
            this.mnemonicButton.UseVisualStyleBackColor = true;
            this.mnemonicButton.Visible = false;
            this.mnemonicButton.Click += new System.EventHandler(this.mnemonicButton_Click);
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Location = new System.Drawing.Point(3, 3);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(56, 17);
            this.easyRadioButton.TabIndex = 7;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Легко";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            this.easyRadioButton.CheckedChanged += new System.EventHandler(this.easyRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(62, 3);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 8;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Средне";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(130, 3);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(61, 17);
            this.hardRadioButton.TabIndex = 9;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Трудно";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            this.hardRadioButton.CheckedChanged += new System.EventHandler(this.hardRadioButton_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(102, 81);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // errorTranslationLabel
            // 
            this.errorTranslationLabel.AutoSize = true;
            this.errorTranslationLabel.Location = new System.Drawing.Point(116, 3);
            this.errorTranslationLabel.Name = "errorTranslationLabel";
            this.errorTranslationLabel.Size = new System.Drawing.Size(111, 13);
            this.errorTranslationLabel.TabIndex = 5;
            this.errorTranslationLabel.Text = "Ошибочный перевод";
            this.errorTranslationLabel.Visible = false;
            this.errorTranslationLabel.Click += new System.EventHandler(this.elements_Click);
            // 
            // sentence1Label
            // 
            this.sentence1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentence1Label.Location = new System.Drawing.Point(3, 60);
            this.sentence1Label.Name = "sentence1Label";
            this.sentence1Label.Size = new System.Drawing.Size(376, 31);
            this.sentence1Label.TabIndex = 6;
            this.sentence1Label.Text = "Предложение1";
            this.sentence1Label.Visible = false;
            // 
            // sentence2Label
            // 
            this.sentence2Label.Location = new System.Drawing.Point(3, 91);
            this.sentence2Label.Name = "sentence2Label";
            this.sentence2Label.Size = new System.Drawing.Size(376, 27);
            this.sentence2Label.TabIndex = 7;
            this.sentence2Label.Text = "Предложение2";
            this.sentence2Label.Visible = false;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CardControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(750, 148);
            this.Click += new System.EventHandler(this.CardControl_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nounLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label studyDateLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Button mnemonicButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label errorTranslationLabel;
        private System.Windows.Forms.Label sentence2Label;
        private System.Windows.Forms.Label sentence1Label;
    }
}

namespace mnemonika.AppForms
{
    partial class CreateUpdateCardForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label partOfSpeechIdLabel;
            System.Windows.Forms.Label themeIdLabel;
            System.Windows.Forms.Label studyDateLabel;
            System.Windows.Forms.Label auxIdLabel;
            System.Windows.Forms.Label difficultyIdLabel;
            System.Windows.Forms.Label exampleLabel;
            System.Windows.Forms.Label hintLabel;
            System.Windows.Forms.Label tipicalMistakeLabel;
            System.Windows.Forms.Label britishTransLabel;
            System.Windows.Forms.Label northAmericanTransLabel;
            System.Windows.Forms.Label photoLabel;
            this.shapkin_mnemonikaDataSet = new mnemonika.Shapkin_mnemonikaDataSet();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.WordTableAdapter();
            this.tableAdapterManager = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager();
            this.auxiTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.AuxiTableAdapter();
            this.difficultyTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.DifficultyTableAdapter();
            this.partOfSpeechTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.PartOfSpeechTableAdapter();
            this.themeTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.ThemeTableAdapter();
            this.partOfSpeechIdComboBox = new System.Windows.Forms.ComboBox();
            this.partOfSpeechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeIdComboBox = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.auxIdComboBox = new System.Windows.Forms.ComboBox();
            this.auxiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.difficultyIdComboBox = new System.Windows.Forms.ComboBox();
            this.difficultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hintTextBox = new System.Windows.Forms.TextBox();
            this.basicExampleMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.generalCardMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exampleTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tipicalMistakeTextBox = new System.Windows.Forms.TextBox();
            this.britishTransTextBox = new System.Windows.Forms.TextBox();
            this.northAmericanTransTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            partOfSpeechIdLabel = new System.Windows.Forms.Label();
            themeIdLabel = new System.Windows.Forms.Label();
            studyDateLabel = new System.Windows.Forms.Label();
            auxIdLabel = new System.Windows.Forms.Label();
            difficultyIdLabel = new System.Windows.Forms.Label();
            exampleLabel = new System.Windows.Forms.Label();
            hintLabel = new System.Windows.Forms.Label();
            tipicalMistakeLabel = new System.Windows.Forms.Label();
            britishTransLabel = new System.Windows.Forms.Label();
            northAmericanTransLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partOfSpeechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.photoButton);
            this.splitContainer1.Panel2.Controls.Add(tipicalMistakeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tipicalMistakeTextBox);
            this.splitContainer1.Panel2.Controls.Add(britishTransLabel);
            this.splitContainer1.Panel2.Controls.Add(this.britishTransTextBox);
            this.splitContainer1.Panel2.Controls.Add(northAmericanTransLabel);
            this.splitContainer1.Panel2.Controls.Add(this.northAmericanTransTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.exampleTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(partOfSpeechIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.partOfSpeechIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(themeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.themeIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(studyDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.studyDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(auxIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.auxIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(difficultyIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.difficultyIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(exampleLabel);
            this.splitContainer1.Panel2.Controls.Add(hintLabel);
            this.splitContainer1.Panel2.Controls.Add(this.hintTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.basicExampleMarkCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.generalCardMarkCheckBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 534);
            // 
            // partOfSpeechIdLabel
            // 
            partOfSpeechIdLabel.AutoSize = true;
            partOfSpeechIdLabel.Location = new System.Drawing.Point(229, 19);
            partOfSpeechIdLabel.Name = "partOfSpeechIdLabel";
            partOfSpeechIdLabel.Size = new System.Drawing.Size(61, 14);
            partOfSpeechIdLabel.TabIndex = 0;
            partOfSpeechIdLabel.Text = "Часть речи";
            // 
            // themeIdLabel
            // 
            themeIdLabel.AutoSize = true;
            themeIdLabel.Location = new System.Drawing.Point(229, 47);
            themeIdLabel.Name = "themeIdLabel";
            themeIdLabel.Size = new System.Drawing.Size(32, 14);
            themeIdLabel.TabIndex = 2;
            themeIdLabel.Text = "Тема";
            // 
            // studyDateLabel
            // 
            studyDateLabel.AutoSize = true;
            studyDateLabel.Location = new System.Drawing.Point(229, 76);
            studyDateLabel.Name = "studyDateLabel";
            studyDateLabel.Size = new System.Drawing.Size(77, 14);
            studyDateLabel.TabIndex = 4;
            studyDateLabel.Text = "Дата изучения";
            // 
            // auxIdLabel
            // 
            auxIdLabel.AutoSize = true;
            auxIdLabel.Location = new System.Drawing.Point(229, 101);
            auxIdLabel.Name = "auxIdLabel";
            auxIdLabel.Size = new System.Drawing.Size(66, 14);
            auxIdLabel.TabIndex = 6;
            auxIdLabel.Text = "Слово/фраза";
            // 
            // difficultyIdLabel
            // 
            difficultyIdLabel.AutoSize = true;
            difficultyIdLabel.Location = new System.Drawing.Point(229, 233);
            difficultyIdLabel.Name = "difficultyIdLabel";
            difficultyIdLabel.Size = new System.Drawing.Size(59, 14);
            difficultyIdLabel.TabIndex = 8;
            difficultyIdLabel.Text = "Сложность";
            // 
            // exampleLabel
            // 
            exampleLabel.AutoSize = true;
            exampleLabel.Location = new System.Drawing.Point(229, 261);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new System.Drawing.Size(45, 14);
            exampleLabel.TabIndex = 10;
            exampleLabel.Text = "Пример";
            // 
            // hintLabel
            // 
            hintLabel.AutoSize = true;
            hintLabel.Location = new System.Drawing.Point(229, 289);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new System.Drawing.Size(55, 14);
            hintLabel.TabIndex = 12;
            hintLabel.Text = "Подсказка";
            // 
            // tipicalMistakeLabel
            // 
            tipicalMistakeLabel.AutoSize = true;
            tipicalMistakeLabel.Location = new System.Drawing.Point(229, 129);
            tipicalMistakeLabel.Name = "tipicalMistakeLabel";
            tipicalMistakeLabel.Size = new System.Drawing.Size(94, 14);
            tipicalMistakeLabel.TabIndex = 19;
            tipicalMistakeLabel.Text = "Типичная ошибка";
            // 
            // britishTransLabel
            // 
            britishTransLabel.AutoSize = true;
            britishTransLabel.Location = new System.Drawing.Point(229, 155);
            britishTransLabel.Name = "britishTransLabel";
            britishTransLabel.Size = new System.Drawing.Size(88, 14);
            britishTransLabel.TabIndex = 21;
            britishTransLabel.Text = "Br транскрипция";
            // 
            // northAmericanTransLabel
            // 
            northAmericanTransLabel.AutoSize = true;
            northAmericanTransLabel.Location = new System.Drawing.Point(229, 181);
            northAmericanTransLabel.Name = "northAmericanTransLabel";
            northAmericanTransLabel.Size = new System.Drawing.Size(94, 14);
            northAmericanTransLabel.TabIndex = 23;
            northAmericanTransLabel.Text = "Am транскрипция";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(229, 207);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(32, 14);
            photoLabel.TabIndex = 25;
            photoLabel.Text = "Фото";
            // 
            // shapkin_mnemonikaDataSet
            // 
            this.shapkin_mnemonikaDataSet.DataSetName = "Shapkin_mnemonikaDataSet";
            this.shapkin_mnemonikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            this.wordBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // wordTableAdapter
            // 
            this.wordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuxiTableAdapter = this.auxiTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DifficultyTableAdapter = this.difficultyTableAdapter;
            this.tableAdapterManager.MnemonicTableAdapter = null;
            this.tableAdapterManager.PartOfSpeechTableAdapter = this.partOfSpeechTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = this.themeTableAdapter;
            this.tableAdapterManager.UpdateOrder = mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.WordTableAdapter = this.wordTableAdapter;
            // 
            // auxiTableAdapter
            // 
            this.auxiTableAdapter.ClearBeforeFill = true;
            // 
            // difficultyTableAdapter
            // 
            this.difficultyTableAdapter.ClearBeforeFill = true;
            // 
            // partOfSpeechTableAdapter
            // 
            this.partOfSpeechTableAdapter.ClearBeforeFill = true;
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // partOfSpeechIdComboBox
            // 
            this.partOfSpeechIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "PartOfSpeechId", true));
            this.partOfSpeechIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wordBindingSource, "PartOfSpeechId", true));
            this.partOfSpeechIdComboBox.DataSource = this.partOfSpeechBindingSource;
            this.partOfSpeechIdComboBox.DisplayMember = "PartOfSpeech";
            this.partOfSpeechIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partOfSpeechIdComboBox.FormattingEnabled = true;
            this.partOfSpeechIdComboBox.Location = new System.Drawing.Point(341, 16);
            this.partOfSpeechIdComboBox.Name = "partOfSpeechIdComboBox";
            this.partOfSpeechIdComboBox.Size = new System.Drawing.Size(257, 22);
            this.partOfSpeechIdComboBox.TabIndex = 1;
            this.partOfSpeechIdComboBox.ValueMember = "IdPartOfSpeech";
            // 
            // partOfSpeechBindingSource
            // 
            this.partOfSpeechBindingSource.DataMember = "PartOfSpeech";
            this.partOfSpeechBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // themeIdComboBox
            // 
            this.themeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "ThemeId", true));
            this.themeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wordBindingSource, "ThemeId", true));
            this.themeIdComboBox.DataSource = this.themeBindingSource;
            this.themeIdComboBox.DisplayMember = "Theme";
            this.themeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeIdComboBox.FormattingEnabled = true;
            this.themeIdComboBox.Location = new System.Drawing.Point(341, 44);
            this.themeIdComboBox.Name = "themeIdComboBox";
            this.themeIdComboBox.Size = new System.Drawing.Size(257, 22);
            this.themeIdComboBox.TabIndex = 3;
            this.themeIdComboBox.ValueMember = "IdTheme";
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataMember = "Theme";
            this.themeBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // studyDateDateTimePicker
            // 
            this.studyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.wordBindingSource, "StudyDate", true));
            this.studyDateDateTimePicker.Location = new System.Drawing.Point(341, 72);
            this.studyDateDateTimePicker.Name = "studyDateDateTimePicker";
            this.studyDateDateTimePicker.Size = new System.Drawing.Size(257, 20);
            this.studyDateDateTimePicker.TabIndex = 5;
            // 
            // auxIdComboBox
            // 
            this.auxIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "AuxId", true));
            this.auxIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wordBindingSource, "AuxId", true));
            this.auxIdComboBox.DataSource = this.auxiBindingSource;
            this.auxIdComboBox.DisplayMember = "EngWord";
            this.auxIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auxIdComboBox.FormattingEnabled = true;
            this.auxIdComboBox.Location = new System.Drawing.Point(341, 98);
            this.auxIdComboBox.Name = "auxIdComboBox";
            this.auxIdComboBox.Size = new System.Drawing.Size(257, 22);
            this.auxIdComboBox.TabIndex = 7;
            this.auxIdComboBox.ValueMember = "IdAux";
            this.auxIdComboBox.SelectedIndexChanged += new System.EventHandler(this.auxIdComboBox_SelectedIndexChanged);
            // 
            // auxiBindingSource
            // 
            this.auxiBindingSource.DataMember = "Auxi";
            this.auxiBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // difficultyIdComboBox
            // 
            this.difficultyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "DifficultyId", true));
            this.difficultyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wordBindingSource, "DifficultyId", true));
            this.difficultyIdComboBox.DataSource = this.difficultyBindingSource;
            this.difficultyIdComboBox.DisplayMember = "Difficulty";
            this.difficultyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyIdComboBox.FormattingEnabled = true;
            this.difficultyIdComboBox.Location = new System.Drawing.Point(341, 230);
            this.difficultyIdComboBox.Name = "difficultyIdComboBox";
            this.difficultyIdComboBox.Size = new System.Drawing.Size(257, 22);
            this.difficultyIdComboBox.TabIndex = 9;
            this.difficultyIdComboBox.ValueMember = "IdDifficulty";
            // 
            // difficultyBindingSource
            // 
            this.difficultyBindingSource.DataMember = "Difficulty";
            this.difficultyBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // hintTextBox
            // 
            this.hintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "Hint", true));
            this.hintTextBox.Location = new System.Drawing.Point(341, 286);
            this.hintTextBox.MaxLength = 50;
            this.hintTextBox.Name = "hintTextBox";
            this.hintTextBox.Size = new System.Drawing.Size(257, 20);
            this.hintTextBox.TabIndex = 13;
            // 
            // basicExampleMarkCheckBox
            // 
            this.basicExampleMarkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.wordBindingSource, "BasicExampleMark", true));
            this.basicExampleMarkCheckBox.Location = new System.Drawing.Point(232, 312);
            this.basicExampleMarkCheckBox.Name = "basicExampleMarkCheckBox";
            this.basicExampleMarkCheckBox.Size = new System.Drawing.Size(366, 24);
            this.basicExampleMarkCheckBox.TabIndex = 15;
            this.basicExampleMarkCheckBox.Text = "Основной пример";
            this.basicExampleMarkCheckBox.UseVisualStyleBackColor = true;
            // 
            // generalCardMarkCheckBox
            // 
            this.generalCardMarkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.wordBindingSource, "GeneralCardMark", true));
            this.generalCardMarkCheckBox.Location = new System.Drawing.Point(232, 342);
            this.generalCardMarkCheckBox.Name = "generalCardMarkCheckBox";
            this.generalCardMarkCheckBox.Size = new System.Drawing.Size(366, 24);
            this.generalCardMarkCheckBox.TabIndex = 17;
            this.generalCardMarkCheckBox.Text = "Общая карточка";
            this.generalCardMarkCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.saveButton.Location = new System.Drawing.Point(232, 368);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(285, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exampleTextBox
            // 
            this.exampleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordBindingSource, "Example", true));
            this.exampleTextBox.Location = new System.Drawing.Point(341, 261);
            this.exampleTextBox.MaxLength = 150;
            this.exampleTextBox.Name = "exampleTextBox";
            this.exampleTextBox.Size = new System.Drawing.Size(257, 20);
            this.exampleTextBox.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tipicalMistakeTextBox
            // 
            this.tipicalMistakeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auxiBindingSource, "TipicalMistake", true));
            this.tipicalMistakeTextBox.Location = new System.Drawing.Point(341, 126);
            this.tipicalMistakeTextBox.MaxLength = 150;
            this.tipicalMistakeTextBox.Name = "tipicalMistakeTextBox";
            this.tipicalMistakeTextBox.Size = new System.Drawing.Size(257, 20);
            this.tipicalMistakeTextBox.TabIndex = 20;
            // 
            // britishTransTextBox
            // 
            this.britishTransTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auxiBindingSource, "BritishTrans", true));
            this.britishTransTextBox.Location = new System.Drawing.Point(341, 152);
            this.britishTransTextBox.MaxLength = 150;
            this.britishTransTextBox.Name = "britishTransTextBox";
            this.britishTransTextBox.Size = new System.Drawing.Size(257, 20);
            this.britishTransTextBox.TabIndex = 22;
            // 
            // northAmericanTransTextBox
            // 
            this.northAmericanTransTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auxiBindingSource, "NorthAmericanTrans", true));
            this.northAmericanTransTextBox.Location = new System.Drawing.Point(341, 178);
            this.northAmericanTransTextBox.MaxLength = 150;
            this.northAmericanTransTextBox.Name = "northAmericanTransTextBox";
            this.northAmericanTransTextBox.Size = new System.Drawing.Size(257, 20);
            this.northAmericanTransTextBox.TabIndex = 24;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auxiBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(341, 204);
            this.photoTextBox.MaxLength = 150;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(198, 20);
            this.photoTextBox.TabIndex = 26;
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(545, 203);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(53, 23);
            this.photoButton.TabIndex = 27;
            this.photoButton.Text = "Фото";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(523, 368);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CreateUpdateCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Name = "CreateUpdateCardForm";
            this.Load += new System.EventHandler(this.CreateUpdateCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partOfSpeechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_mnemonikaDataSet shapkin_mnemonikaDataSet;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.WordTableAdapter wordTableAdapter;
        private Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox exampleTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox partOfSpeechIdComboBox;
        private System.Windows.Forms.ComboBox themeIdComboBox;
        private System.Windows.Forms.DateTimePicker studyDateDateTimePicker;
        private System.Windows.Forms.ComboBox auxIdComboBox;
        private System.Windows.Forms.ComboBox difficultyIdComboBox;
        private System.Windows.Forms.TextBox hintTextBox;
        private System.Windows.Forms.CheckBox basicExampleMarkCheckBox;
        private System.Windows.Forms.CheckBox generalCardMarkCheckBox;
        private Shapkin_mnemonikaDataSetTableAdapters.PartOfSpeechTableAdapter partOfSpeechTableAdapter;
        private System.Windows.Forms.BindingSource partOfSpeechBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.AuxiTableAdapter auxiTableAdapter;
        private System.Windows.Forms.BindingSource auxiBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.DifficultyTableAdapter difficultyTableAdapter;
        private System.Windows.Forms.BindingSource difficultyBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tipicalMistakeTextBox;
        private System.Windows.Forms.TextBox britishTransTextBox;
        private System.Windows.Forms.TextBox northAmericanTransTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

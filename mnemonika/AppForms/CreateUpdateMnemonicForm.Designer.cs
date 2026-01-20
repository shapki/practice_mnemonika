namespace mnemonika.AppForms
{
    partial class CreateUpdateMnemonicForm
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
            System.Windows.Forms.Label mnemonicDeviceLabel;
            this.shapkin_mnemonikaDataSet = new mnemonika.Shapkin_mnemonikaDataSet();
            this.mnemonicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnemonicTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.MnemonicTableAdapter();
            this.tableAdapterManager = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager();
            this.mnemonicDeviceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.wordInfoLabel = new System.Windows.Forms.Label();
            this.mnemonicListBox = new System.Windows.Forms.ListBox();
            mnemonicDeviceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemonicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mnemonicListBox);
            this.splitContainer1.Panel2.Controls.Add(this.wordInfoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(mnemonicDeviceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.mnemonicDeviceTextBox);
            // 
            // mnemonicDeviceLabel
            // 
            mnemonicDeviceLabel.AutoSize = true;
            mnemonicDeviceLabel.Location = new System.Drawing.Point(447, 146);
            mnemonicDeviceLabel.Name = "mnemonicDeviceLabel";
            mnemonicDeviceLabel.Size = new System.Drawing.Size(58, 14);
            mnemonicDeviceLabel.TabIndex = 2;
            mnemonicDeviceLabel.Text = "Мнемоник";
            // 
            // shapkin_mnemonikaDataSet
            // 
            this.shapkin_mnemonikaDataSet.DataSetName = "Shapkin_mnemonikaDataSet";
            this.shapkin_mnemonikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnemonicBindingSource
            // 
            this.mnemonicBindingSource.DataMember = "Mnemonic";
            this.mnemonicBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // mnemonicTableAdapter
            // 
            this.mnemonicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuxiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DifficultyTableAdapter = null;
            this.tableAdapterManager.MnemonicTableAdapter = this.mnemonicTableAdapter;
            this.tableAdapterManager.PartOfSpeechTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.WordTableAdapter = null;
            // 
            // mnemonicDeviceTextBox
            // 
            this.mnemonicDeviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mnemonicBindingSource, "MnemonicDevice", true));
            this.mnemonicDeviceTextBox.Location = new System.Drawing.Point(548, 143);
            this.mnemonicDeviceTextBox.MaxLength = 150;
            this.mnemonicDeviceTextBox.Name = "mnemonicDeviceTextBox";
            this.mnemonicDeviceTextBox.Size = new System.Drawing.Size(237, 20);
            this.mnemonicDeviceTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.saveButton.Location = new System.Drawing.Point(450, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(254, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(710, 169);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // wordInfoLabel
            // 
            this.wordInfoLabel.AutoSize = true;
            this.wordInfoLabel.Location = new System.Drawing.Point(447, 120);
            this.wordInfoLabel.Name = "wordInfoLabel";
            this.wordInfoLabel.Size = new System.Drawing.Size(36, 14);
            this.wordInfoLabel.TabIndex = 7;
            this.wordInfoLabel.Text = "Слово";
            // 
            // mnemonicListBox
            // 
            this.mnemonicListBox.Enabled = false;
            this.mnemonicListBox.FormattingEnabled = true;
            this.mnemonicListBox.ItemHeight = 14;
            this.mnemonicListBox.Location = new System.Drawing.Point(3, 3);
            this.mnemonicListBox.Name = "mnemonicListBox";
            this.mnemonicListBox.Size = new System.Drawing.Size(436, 340);
            this.mnemonicListBox.TabIndex = 8;
            // 
            // CreateUpdateMnemonicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CreateUpdateMnemonicForm";
            this.Load += new System.EventHandler(this.CreateUpdateMnemonicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemonicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_mnemonikaDataSet shapkin_mnemonikaDataSet;
        private System.Windows.Forms.BindingSource mnemonicBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.MnemonicTableAdapter mnemonicTableAdapter;
        private Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mnemonicDeviceTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label wordInfoLabel;
        private System.Windows.Forms.ListBox mnemonicListBox;
    }
}

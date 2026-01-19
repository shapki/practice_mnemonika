namespace mnemonika.AppForms
{
    partial class LoginForm
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.shapkin_mnemonikaDataSet = new mnemonika.Shapkin_mnemonikaDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guestButton);
            this.splitContainer1.Panel2.Controls.Add(this.signInButton);
            this.splitContainer1.Panel2.Controls.Add(loginLabel);
            this.splitContainer1.Panel2.Controls.Add(this.loginTextBox);
            this.splitContainer1.Panel2.Controls.Add(passwordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passwordTextBox);
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(284, 103);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(37, 14);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(284, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(42, 14);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль";
            // 
            // shapkin_mnemonikaDataSet
            // 
            this.shapkin_mnemonikaDataSet.DataSetName = "Shapkin_mnemonikaDataSet";
            this.shapkin_mnemonikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.shapkin_mnemonikaDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuxiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DifficultyTableAdapter = null;
            this.tableAdapterManager.MnemonicTableAdapter = null;
            this.tableAdapterManager.PartOfSpeechTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mnemonika.Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.WordTableAdapter = null;
            // 
            // loginTextBox
            // 
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(342, 100);
            this.loginTextBox.MaxLength = 150;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(179, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(342, 126);
            this.passwordTextBox.MaxLength = 150;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(179, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.signInButton.Location = new System.Drawing.Point(287, 152);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(234, 23);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.guestButton.Location = new System.Drawing.Point(713, 311);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(75, 23);
            this.guestButton.TabIndex = 5;
            this.guestButton.Text = "Гость";
            this.guestButton.UseVisualStyleBackColor = false;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_mnemonikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_mnemonikaDataSet shapkin_mnemonikaDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Shapkin_mnemonikaDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private Shapkin_mnemonikaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button guestButton;
        private System.Windows.Forms.Button signInButton;
    }
}

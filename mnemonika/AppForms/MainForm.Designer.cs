namespace mnemonika.AppForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.mnemonikButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.partOfSpeechComboBox = new System.Windows.Forms.ComboBox();
            this.partOfSpeechLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(533, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить карточку";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // mnemonikButton
            // 
            this.mnemonikButton.Location = new System.Drawing.Point(654, 0);
            this.mnemonikButton.Name = "mnemonikButton";
            this.mnemonikButton.Size = new System.Drawing.Size(138, 23);
            this.mnemonikButton.TabIndex = 6;
            this.mnemonikButton.Text = "Мнемонические приёмы";
            this.mnemonikButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(46, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(3, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(40, 14);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "Поиск:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.partOfSpeechComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.partOfSpeechLabel);
            this.splitContainer2.Panel1.Controls.Add(this.searchLabel);
            this.splitContainer2.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.addButton);
            this.splitContainer2.Panel1.Controls.Add(this.mnemonikButton);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 346);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // partOfSpeechComboBox
            // 
            this.partOfSpeechComboBox.FormattingEnabled = true;
            this.partOfSpeechComboBox.Location = new System.Drawing.Point(222, 2);
            this.partOfSpeechComboBox.Name = "partOfSpeechComboBox";
            this.partOfSpeechComboBox.Size = new System.Drawing.Size(121, 22);
            this.partOfSpeechComboBox.TabIndex = 10;
            // 
            // partOfSpeechLabel
            // 
            this.partOfSpeechLabel.AutoSize = true;
            this.partOfSpeechLabel.Location = new System.Drawing.Point(152, 5);
            this.partOfSpeechLabel.Name = "partOfSpeechLabel";
            this.partOfSpeechLabel.Size = new System.Drawing.Size(64, 14);
            this.partOfSpeechLabel.TabIndex = 9;
            this.partOfSpeechLabel.Text = "Часть речи:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 317);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button mnemonikButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label partOfSpeechLabel;
        private System.Windows.Forms.ComboBox partOfSpeechComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
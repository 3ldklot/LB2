namespace Lab2
{
    partial class Form2
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
            listBoxLog = new ListBox();
            groupBox2 = new GroupBox();
            comboBoxObjects = new ComboBox();
            buttonGrant = new Button();
            buttonLevel3 = new Button();
            buttonLevel2 = new Button();
            buttonLevel1 = new Button();
            chooseObjectLabel = new Label();
            buttonExit = new Button();
            buttonChangeUser = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(11, 114);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(374, 169);
            listBoxLog.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxObjects);
            groupBox2.Controls.Add(buttonGrant);
            groupBox2.Controls.Add(buttonLevel3);
            groupBox2.Controls.Add(buttonLevel2);
            groupBox2.Controls.Add(buttonLevel1);
            groupBox2.Controls.Add(chooseObjectLabel);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 96);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // comboBoxObjects
            // 
            comboBoxObjects.FormattingEnabled = true;
            comboBoxObjects.Items.AddRange(new object[] { "Объект 1", "Объект 2", "Объект 3", "Объект 4" });
            comboBoxObjects.Location = new Point(6, 33);
            comboBoxObjects.Name = "comboBoxObjects";
            comboBoxObjects.Size = new Size(121, 23);
            comboBoxObjects.TabIndex = 7;
            comboBoxObjects.SelectedIndexChanged += comboBoxObjects_SelectedIndexChanged;
            // 
            // buttonGrant
            // 
            buttonGrant.Enabled = false;
            buttonGrant.Location = new Point(6, 62);
            buttonGrant.Name = "buttonGrant";
            buttonGrant.Size = new Size(361, 23);
            buttonGrant.TabIndex = 7;
            buttonGrant.Text = "Предоставить доступ";
            buttonGrant.UseVisualStyleBackColor = true;
            buttonGrant.Click += buttonGrant_Click;
            // 
            // buttonLevel3
            // 
            buttonLevel3.Enabled = false;
            buttonLevel3.Location = new Point(292, 33);
            buttonLevel3.Name = "buttonLevel3";
            buttonLevel3.Size = new Size(75, 23);
            buttonLevel3.TabIndex = 8;
            buttonLevel3.Text = "Чт. / зап.";
            buttonLevel3.UseVisualStyleBackColor = true;
            buttonLevel3.Click += buttonLevel3_Click;
            // 
            // buttonLevel2
            // 
            buttonLevel2.Enabled = false;
            buttonLevel2.Location = new Point(220, 33);
            buttonLevel2.Name = "buttonLevel2";
            buttonLevel2.Size = new Size(66, 23);
            buttonLevel2.TabIndex = 7;
            buttonLevel2.Text = "Запись";
            buttonLevel2.UseVisualStyleBackColor = true;
            buttonLevel2.Click += buttonLevel2_Click;
            // 
            // buttonLevel1
            // 
            buttonLevel1.Enabled = false;
            buttonLevel1.Location = new Point(148, 33);
            buttonLevel1.Name = "buttonLevel1";
            buttonLevel1.Size = new Size(66, 23);
            buttonLevel1.TabIndex = 6;
            buttonLevel1.Text = "Чтение";
            buttonLevel1.UseVisualStyleBackColor = true;
            buttonLevel1.Click += buttonLevel1_Click;
            // 
            // chooseObjectLabel
            // 
            chooseObjectLabel.AutoSize = true;
            chooseObjectLabel.Location = new Point(6, 15);
            chooseObjectLabel.Name = "chooseObjectLabel";
            chooseObjectLabel.Size = new Size(102, 15);
            chooseObjectLabel.TabIndex = 5;
            chooseObjectLabel.Text = "Выберите объект";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(295, 293);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(84, 23);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Завершить";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonChangeUser
            // 
            buttonChangeUser.Location = new Point(18, 293);
            buttonChangeUser.Name = "buttonChangeUser";
            buttonChangeUser.Size = new Size(143, 23);
            buttonChangeUser.TabIndex = 8;
            buttonChangeUser.Text = "Сменить пользователя";
            buttonChangeUser.UseVisualStyleBackColor = true;
            buttonChangeUser.Click += buttonChangeUser_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 325);
            Controls.Add(buttonChangeUser);
            Controls.Add(buttonExit);
            Controls.Add(groupBox2);
            Controls.Add(listBoxLog);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxLog;
        private GroupBox groupBox2;
        private Button buttonLevel3;
        private Button buttonLevel2;
        private Button buttonLevel1;
        private Label chooseObjectLabel;
        private Button buttonGrant;
        private ComboBox comboBoxObjects;
        private Button buttonExit;
        private Button buttonChangeUser;
    }
}
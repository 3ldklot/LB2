namespace Lab2
{
    partial class Form3
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
            comboBoxGrantueted = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            comboBoxAccess = new ComboBox();
            groupBox1 = new GroupBox();
            buttonGrantFinally = new Button();
            buttonReturn = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxGrantueted
            // 
            comboBoxGrantueted.FormattingEnabled = true;
            comboBoxGrantueted.Location = new Point(10, 27);
            comboBoxGrantueted.Name = "comboBoxGrantueted";
            comboBoxGrantueted.Size = new Size(299, 23);
            comboBoxGrantueted.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите пользователя для предоставления доступа\r\n";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 4;
            label3.Text = "Выберите тип доступа";
            // 
            // comboBoxAccess
            // 
            comboBoxAccess.FormattingEnabled = true;
            comboBoxAccess.Location = new Point(12, 73);
            comboBoxAccess.Name = "comboBoxAccess";
            comboBoxAccess.Size = new Size(144, 23);
            comboBoxAccess.TabIndex = 5;
            comboBoxAccess.SelectedIndexChanged += comboBoxAccess_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonGrantFinally);
            groupBox1.Location = new Point(165, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 45);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // buttonGrantFinally
            // 
            buttonGrantFinally.Enabled = false;
            buttonGrantFinally.Location = new Point(6, 16);
            buttonGrantFinally.Name = "buttonGrantFinally";
            buttonGrantFinally.Size = new Size(138, 23);
            buttonGrantFinally.TabIndex = 0;
            buttonGrantFinally.Text = "Предоставить";
            buttonGrantFinally.UseVisualStyleBackColor = true;
            buttonGrantFinally.Click += button1_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(177, 207);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(138, 23);
            buttonReturn.TabIndex = 1;
            buttonReturn.Text = "Вернуться";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(303, 94);
            listBox1.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 239);
            Controls.Add(buttonReturn);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxAccess);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBoxGrantueted);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGrantueted;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxAccess;
        private GroupBox groupBox1;
        private Button buttonGrantFinally;
        private ListBox listBox1;
        private Button buttonReturn;
    }
}
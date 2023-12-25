namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSubmit = new Button();
            textBoxUsername = new TextBox();
            label1 = new Label();
            labelIncorrect = new Label();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(99, 68);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(82, 23);
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "Вход";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += button1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(11, 24);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(267, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите логин:";
            // 
            // labelIncorrect
            // 
            labelIncorrect.AutoSize = true;
            labelIncorrect.ForeColor = Color.DarkRed;
            labelIncorrect.Location = new Point(77, 50);
            labelIncorrect.Name = "labelIncorrect";
            labelIncorrect.Size = new Size(127, 15);
            labelIncorrect.TabIndex = 3;
            labelIncorrect.Text = "Неверно введено имя";
            labelIncorrect.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 98);
            Controls.Add(labelIncorrect);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private TextBox textBoxUsername;
        private Label label1;
        private Label labelIncorrect;
    }
}
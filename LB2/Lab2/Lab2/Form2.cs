using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        private string username = String.Empty;

        private Matrix _matrix = new Matrix();
        public Form2(String Data, Matrix matrix)
        {
            InitializeComponent();
            username = Data;
            _matrix = matrix;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "User " + username;
            listBoxLog.Items.Add("User: " + username);
            listBoxLog.Items.Add("Succesful authentification");
            listBoxLog.Items.Add("Choose an object...");
        }



        private void comboBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxObjects.Items.Count; i++)
            {
                if (comboBoxObjects.SelectedIndex == i)
                {
                    string access = _matrix.getAccessInfo(username, i + 1);
                    listBoxLog.Items.Add("Chosen object: " + (i + 1).ToString());
                    if (access == "3")
                    {
                        buttonLevel1.Enabled = true;
                        buttonLevel2.Enabled = true;
                        buttonLevel3.Enabled = true;
                        buttonGrant.Enabled = true;
                        listBoxLog.Items.Add("You have absolute rights to info of that object ");

                    }
                    else if (access == "2")
                    {
                        buttonLevel1.Enabled = false;
                        buttonLevel2.Enabled = true;
                        buttonLevel3.Enabled = false;
                        buttonGrant.Enabled = true;
                        listBoxLog.Items.Add("You have rights to write");
                    }
                    else if (access == "1")
                    {
                        buttonLevel1.Enabled = true;
                        buttonLevel2.Enabled = false;
                        buttonLevel3.Enabled = false;
                        buttonGrant.Enabled = true;
                        listBoxLog.Items.Add("You have rights to read...good for you");
                    }
                    else if (access == "0")
                    {
                        buttonLevel1.Enabled = false;
                        buttonLevel2.Enabled = false;
                        buttonLevel3.Enabled = false;
                        buttonGrant.Enabled = false;
                        listBoxLog.Items.Add("There is nothing you can do");
                    }
                }
            }
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(_matrix);
            newForm.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGrant_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(username, comboBoxObjects.SelectedIndex + 1, _matrix);
            newForm.Show();
            Hide();
        }

        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Add("Successfully read on " + comboBoxObjects.Text);
        }

        private void buttonLevel2_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Add("Successfully written on " + comboBoxObjects.Text);
        }

        private void buttonLevel3_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Add("Successfully corrupted data on " + comboBoxObjects.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab2
{
    public partial class Form3 : Form
    {
        Matrix _matrix = new Matrix();
        string _granter;
        int _objectNumber;
        public Form3(string granter, int objectNumber, Matrix matrix)
        {
            InitializeComponent();
            _granter = granter;
            _matrix = matrix;
            _objectNumber = objectNumber;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < _matrix.getRows(); i++)
            //{
            //    comboBoxGrantueted.Items.Add(_matrix.getName(i));
            //}

            if (_matrix.getAccessInfo(_granter, _objectNumber) == "3")
            {
                comboBoxAccess.Items.Add("Чтение/запись");
                comboBoxAccess.Items.Add("Запись");
                comboBoxAccess.Items.Add("Чтение");
            }
            else if (_matrix.getAccessInfo(_granter, _objectNumber) == "2")
            {
                comboBoxAccess.Items.Add("Запись");
                comboBoxAccess.Items.Add("Чтение");
            }
            else if (_matrix.getAccessInfo(_granter, _objectNumber) == "1")
                comboBoxAccess.Items.Add("Чтение");
            else
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string levelTranslated = string.Empty;
            if (comboBoxAccess.Text == "Чтение")
                levelTranslated = "1";
            else if (comboBoxAccess.Text == "Запись")
                levelTranslated = "2";
            else if (comboBoxAccess.Text == "Чтение/запись")
                levelTranslated = "3";
            listBox1.Items.Add(_matrix.grantAccess(_granter, comboBoxGrantueted.Text, _objectNumber, levelTranslated));
        }

        private void comboBoxObjectNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGrantFinally.Enabled = true;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(_granter, _matrix);
            newForm.Show();
            Close();
        }
    }
}

namespace Lab2
{
   
    public partial class Form1 : Form
    {

        Matrix _matrix = new Matrix();

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Matrix matrix)
        {
            InitializeComponent();
            _matrix = matrix;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            if (_matrix.getName(textBoxUsername.Text) != "No info") { found = true; }
            
            if (found)
            {
                Form2 newForm = new Form2(textBoxUsername.Text, _matrix);
                newForm.Show();
                Hide();
            }
            else labelIncorrect.Visible = true;
        }

    }
}
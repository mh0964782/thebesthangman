using System.Diagnostics;
using System.Windows.Forms;

namespace TheBestHangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_begin_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_highScores_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            //Stops the player from continuing until a name is entered and one of the buttons is clicked.
            if (txt_name.Text != "" && (rdo_easy.Checked || rdo_med.Checked || rdo_hard.Checked))
            {
                // Set the filepath and fielname based on the selected difficulty level
                string Filepath;
                string fileName;
                // Based on the radio button selected, get the desired filepath for words and name of the file.
                if (rdo_easy.Checked)
                {
                    Filepath = Path.Combine(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25), "EasyWords.txt");
                    fileName = "EasyWords.txt";
                }
                else if (rdo_med.Checked)
                {
                    Filepath = Path.Combine(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25), "MedWords.txt");
                    fileName = "MedWords.txt";
                }
                else
                {
                    Filepath = Path.Combine(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25), "HardWords.txt");
                    fileName = "HardWords.txt";
                }
                // Once filepath, filename, and the player's name are given, a new Form2 instance is made and the game begins.
                Form2 currentGame = new Form2(txt_name.Text, Filepath, fileName, 0);
                this.Hide();
                currentGame.ShowDialog();
                this.Close();
            }
        }

        private void btn_highScores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 1)
            {
                Application.OpenForms.OfType<Form3>().First().Close();
            }
            // Create a new Form3 to display the high scores when clicked.
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
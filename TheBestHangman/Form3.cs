using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
namespace TheBestHangman
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Get and display the data for each difficulty's file of high scores.
            LoadData(dgv_easy, "EasyHighscore.txt");
            LoadData(dgv_mid, "MidHighscore.txt");
            LoadData(dgv_hard, "HardHighscore.txt");
        }

        private void LoadData(DataGridView dgv, string fileName)
        {
            // Create each new Data Table
            DataTable dt = new DataTable();

            // Read the data from the text file and store it in a List
            List<string[]> data = new List<string[]>();

            // Get the filepath for the high scores
            string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.Length - 25), fileName);

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Get all the data from the high scores to a list of string arrays, each storing name,high score.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    data.Add(parts);
                }
            }

            // Add headers to the data table.
            string[] headers = data[0];
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            // Remove the string[] headers from the data list, allowing for sorting of the scores.
            data.RemoveAt(0);

            // Sort the data based on the scores in descending order
            data.Sort((x, y) => int.Parse(y[1]).CompareTo(int.Parse(x[1])));

            // For every pair array of name,high score, apply each item to a new row and add the row to the Data Table.
            foreach (string[] row in data)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < row.Length; i++)
                {
                    dr[i] = row[i];
                }
                dt.Rows.Add(dr);
            }
            // Display the data.
            dgv.DataSource = dt;
        }

        private void btn_backtogame_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_backtogame_Click_1(object sender, EventArgs e)
        {
            // Create and show a new instance of Form2
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            // Close the current form
            this.Close();
        }
    }
}

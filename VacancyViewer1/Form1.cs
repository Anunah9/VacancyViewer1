using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VacancyViewer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            
        }
        public void InitializeCustomComponents()
        {
            
            documentTable.AllowUserToAddRows = false;
            documentTable.ReadOnly = false;
            chooseDepartmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] allfiles = Directory.GetFiles("C:\\Users\\Burkov Aleksandr\\source\\repos\\VacancyViewer1\\00. Информация по вакансиям");
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
            }
            chooseDepartmentComboBox.Items.AddRange(allfiles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prevButton_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
;        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.AutoSize = true;
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            //string rtfContent = File.ReadAllText(openFileDialog1.FileName);
            //richTextBox1.Rtf = rtfContent;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Modified = false;
        }

        private void viewerTab_Click(object sender, EventArgs e)
        {

        }
        
        private void chooseDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }
    }
    
}

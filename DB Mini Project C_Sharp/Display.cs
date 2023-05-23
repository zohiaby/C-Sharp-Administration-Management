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

namespace DB_Mini_Project_C_Sharp
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            this.FormClosing += Display_FormClosing;
            //listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            LoadDataIntoListView();
            LoadDataIntoListView1();

        }

        private void Display_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataIntoListView1()
        {
            using (StreamReader reader = new StreamReader("student_data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split('`');
                    listView1.Items.Add(new ListViewItem(data));
                }
            }
        }
        private void LoadDataIntoListView()
        {
            using (StreamReader reader = new StreamReader("teacher_data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split('`');
                    listView2.Items.Add(new ListViewItem(data));
                }
            }
        }
        private void Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Teacher newteacher = new Add_Teacher();
            newteacher.Show();
            this.Hide();
        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            Edit_Teacher editteacher = new Edit_Teacher();
            editteacher.Show();
            this.Hide();
        }

        private void edit_student_Click(object sender, EventArgs e)
        {
            Edit_Student editstudent = new Edit_Student();
            editstudent.Show();
            this.Hide();
        }

        private void edit_teacher_Click(object sender, EventArgs e)
        {
            Edit_Student editstudent = new Edit_Student();
            editstudent.Show();
            this.Hide();
        }

        private void display_teacher_Click(object sender, EventArgs e)
        {
            Display displayre = new Display();
            displayre.Show();
            this.Hide();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }
    }
}

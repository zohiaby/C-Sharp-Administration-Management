using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Mini_Project_C_Sharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormClosing += Main_FormClosing;
        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            Add_Teacher add_teacher1 = new Add_Teacher();
            add_teacher1.Show();
            this.Hide();
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            Add_Student add_student1 = new Add_Student();
            add_student1.Show();
            this.Hide();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void edit_teacher_Click(object sender, EventArgs e)
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void display_teacher_Click(object sender, EventArgs e)
        {
            Display displayre = new Display();
            displayre.Show();
            this.Hide();
        }
    }
}

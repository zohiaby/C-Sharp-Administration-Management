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
    public partial class Add_Student : Form
    {
        string sgender, sfee, line, sid;
        int count = 0, id = 1001;


        public Add_Student()
        {
            InitializeComponent();
            this.FormClosing += Add_Student_FormClosing; 
        }

        private void Paid_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = Paid.Checked;
            if(isChecked == true)
            {
                sfee = "Paid";
            }
            else
            {
                sfee = "Remaining";
            }

        }

        private void s_male_CheckedChanged_1(object sender, EventArgs e)
        {
            sgender = "Male";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void s_fnmae_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            Add_Teacher newteacher = new Add_Teacher();
            newteacher.Show();
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
            Edit_Teacher editteacher = new Edit_Teacher();
            editteacher.Show();
            this.Hide();
        }

        private void display_teacher_Click(object sender, EventArgs e)
        {
            Display displayre = new Display();
            displayre.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void s_blood_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Student newstudent = new Add_Student();
            newstudent.Show();
            this.Hide();
        }

        private void s_female_CheckedChanged_1(object sender, EventArgs e)
        {
            sgender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader countid = new StreamReader("student_data.txt");
            line = countid.ReadLine();
            while (line != null)
            {
                count++;
                line = countid.ReadLine();
            }
            countid.Close();
            id = id + count;
            sid = id.ToString();
            StreamWriter file = File.AppendText("student_data.txt");
            file.WriteLine(sid + "` " + s_fnmae.Text + "` " + s_lname.Text + "` " + s_uname.Text + "` " + s_mail.Text + "` " + this.s_redate.Text + "` " + sgender + "` " + s_blood.Text + "` " + s_contact.Text + "` " + s_adress.Text+"` "+sfee);
            file.Close();
            MessageBox.Show("Student data is Addes Sucessfully");
            Add_Student newstudent = new Add_Student();
            newstudent.Show();
            this.Hide();
        }
        private void Add_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

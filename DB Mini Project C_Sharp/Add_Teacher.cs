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
    
    public partial class Add_Teacher : Form
    {
        string tgender, line,tid;
        int count=0,id=1001;
        public Add_Teacher()
        {
            InitializeComponent();
            this.FormClosing += Add_Teacher_FormClosing;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main go_main = new Main();
            go_main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader countid = new StreamReader("teacher_data.txt");
            line = countid.ReadLine();
            while(line != null)
            {
                count++;
                line = countid.ReadLine();
            }
            countid.Close();
            id = id + count;
            tid = id.ToString();
            StreamWriter file =File.AppendText("teacher_data.txt");
            file.WriteLine(tid+"` "+t_fnmae.Text + "` " + t_lname.Text + "` " + t_uname.Text + "` " + t_email.Text + "` " + this.t_redate.Text + "` " + tgender + "` " + t_blood.Text + "` "+ t_contact.Text + "` " + t_adress.Text);
            MessageBox.Show("Teacher data is Addes Sucessfully");
            file.Close();
            Add_Teacher newteacher = new Add_Teacher();
            newteacher.Show();
            this.Hide();
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
            Add_Student newstudent = new Add_Student();
            newstudent.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void t_male_CheckedChanged(object sender, EventArgs e)
        {
            tgender = "Male";
        }

        private void t_female_CheckedChanged(object sender, EventArgs e)
        {
            tgender = "Female";
        }

        private void Add_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




    }
}

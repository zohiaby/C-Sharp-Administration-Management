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
    public partial class Edit_Student : Form
    {
        string id, fname, lname, uname, email, redate, gender, blood, contact, adress, fee;

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

        private void add_teacher_Click(object sender, EventArgs e)
        {
            Add_Teacher newteacher = new Add_Teacher();
            newteacher.Show();
            this.Hide();
        }

        private void edit_teacher_Click(object sender, EventArgs e)
        {
            Edit_Teacher editteacher = new Edit_Teacher();
            editteacher.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {

        }

        int count;

        public ListViewItem ListViewItem { get; private set; }
        public Edit_Student()
        {
            InitializeComponent();
            FormClosing += Edit_Student_FormClosing;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            LoadDataIntoListView();

        }
        private void LoadDataIntoListView()
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
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && count == 1)
            {
                id = listView1.SelectedItems[0].SubItems[0].Text;
                fname = listView1.SelectedItems[0].SubItems[1].Text = sn_fnmae.Text;
                lname = listView1.SelectedItems[0].SubItems[2].Text = sn_lname.Text;
                uname = listView1.SelectedItems[0].SubItems[3].Text = sn_uname.Text;
                email = listView1.SelectedItems[0].SubItems[4].Text = sn_email.Text;
                redate = listView1.SelectedItems[0].SubItems[5].Text;
                gender = listView1.SelectedItems[0].SubItems[6].Text;
                blood = listView1.SelectedItems[0].SubItems[7].Text;
                contact = listView1.SelectedItems[0].SubItems[8].Text = sn_contact.Text;
                adress = listView1.SelectedItems[0].SubItems[9].Text = sn_adress.Text;
                fee = listView1.SelectedItems[0].SubItems[10].Text;
                MessageBox.Show(fname + " " + lname);
            }
            else
            {
            }
        }
        private void Edit_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void save_Click(object sender, EventArgs e)
        {
            count = 0;
            listView1_SelectedIndexChanged_1(sender, e);
            count = 1;
            listView1_SelectedIndexChanged_1(sender, e);
            MessageBox.Show("Data Updated: " + id + ", " + fname + ", " + lname + ", " + uname + ", " + email + ", " + redate + ", " + gender + ", " + blood + ", " + contact + ", " + adress+ ", "+fee);
            using (StreamWriter writer = new StreamWriter("student_data.txt"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    string row = item.SubItems[0].Text + "` " + item.SubItems[1].Text + "` " + item.SubItems[2].Text + "` " + item.SubItems[3].Text + "` " + item.SubItems[4].Text + "` " + item.SubItems[5].Text + "` " + item.SubItems[6].Text + "` " + item.SubItems[7].Text + "` " + item.SubItems[8].Text + "` " + item.SubItems[9].Text + "` " + item.SubItems[10].Text;
                    writer.WriteLine(row);
                }
            }
            Edit_Student editstudent = new Edit_Student();
            editstudent.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mainmenu = new Main();
            mainmenu.Show();
            this.Hide();
        }
    }
}

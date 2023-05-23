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
    public partial class Edit_Teacher : Form
    {
        string id, fname,lname, uname, email, redate,gender, blood,contact, adress;
        int count;

        private void pictureBox9_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit_Student editstudent = new Edit_Student();
            editstudent.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public ListViewItem ListViewItem { get; private set; }

        public Edit_Teacher()
        {
            InitializeComponent();
            FormClosing += Edit_Teacher_FormClosing;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            LoadDataIntoListView();
        }

        private void Edit_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadDataIntoListView()
        {
            using (StreamReader reader = new StreamReader("teacher_data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split('`');
                    listView1.Items.Add(new ListViewItem(data));
                }
            }
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && count == 1)
            {
               id = listView1.SelectedItems[0].SubItems[0].Text;
               fname = listView1.SelectedItems[0].SubItems[1].Text=tn_fnmae.Text;
               lname = listView1.SelectedItems[0].SubItems[2].Text=tn_lname.Text;
               uname = listView1.SelectedItems[0].SubItems[3].Text=tn_uname.Text;
               email = listView1.SelectedItems[0].SubItems[4].Text=tn_email.Text;
               redate = listView1.SelectedItems[0].SubItems[5].Text;
               gender = listView1.SelectedItems[0].SubItems[6].Text;
               blood = listView1.SelectedItems[0].SubItems[7].Text;
               contact = listView1.SelectedItems[0].SubItems[8].Text=tn_contact.Text;
               adress = listView1.SelectedItems[0].SubItems[9].Text=tn_adress.Text;
            }
            else
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mainmenu = new Main();
            mainmenu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            count = 0;
            ListView1_SelectedIndexChanged(sender,e);
            count = 1;
            ListView1_SelectedIndexChanged(sender, e);
            MessageBox.Show("Data Updated: " + id + ", " + fname+ ", " +lname + ", " + uname + ", " +email + ", " +redate + ", " +gender + ", " +blood + ", " +contact + ", " +adress);
            using (StreamWriter writer = new StreamWriter("teacher_data.txt"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    string row = item.SubItems[0].Text + "` " + item.SubItems[1].Text + "` " + item.SubItems[2].Text + "` " + item.SubItems[3].Text + "` " + item.SubItems[4].Text + "` " + item.SubItems[5].Text + "` " + item.SubItems[6].Text + "` " + item.SubItems[7].Text + "` " + item.SubItems[8].Text + "` " + item.SubItems[9].Text;
                    writer.WriteLine(row);
                }
            }
            Edit_Student editstudent = new Edit_Student();
            editstudent.Show();
            this.Hide();

        }
    }
}

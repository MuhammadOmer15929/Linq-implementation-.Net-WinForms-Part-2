using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        DataGridViewRow data=new DataGridViewRow();
        List<studentInfo> stu = new List<studentInfo>();
        studentInfo std = new studentInfo();
        private void button1_Click(object sender, EventArgs e)
        {
           
            std.StudentID=textBox1.Text;
            std.StudentName = textBox2.Text;
            std.Age = textBox3.Text;
            std.Marks = textBox4.Text;
            std.Gender = textBox5.Text;
            stu.Add(std);

            

            MessageBox.Show("RECORD SAVED SUUCCESSFULLY");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var NAME = from cust in stu
                       where cust.StudentName == textBox6.Text
                       select cust;
            string combine = "";

            foreach(studentInfo q in NAME)
            {
                combine =q.StudentID+" "+q.StudentName+" "+q.Marks+" "+q.Age+" "+q.Gender;
            }
            dataGridView1.DataSource = NAME.ToList();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var NAME = from cust in stu
                       where cust.Marks == textBox7.Text
                       select cust;
            string combine = "";

            foreach (studentInfo q in NAME)
            {
                combine = q.StudentID + " " + q.StudentName + " " + q.Marks + " " + q.Age + " " + q.Gender;
            }
            dataGridView1.DataSource = NAME.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var datatable = new DataTable();
            var NAME = from cust in stu
                       orderby cust.Marks ascending
                       select cust;
            string combine = "";

            foreach (studentInfo q in NAME)
            {
                combine = q.StudentID + " " + q.StudentName + " " + q.Marks + " " + q.Age + " " + q.Gender+" ";
            }
            dataGridView1.DataSource = NAME.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var NAME = from cust in stu
                       orderby cust.Gender ascending
                       select cust;
            string combine = "";

            foreach (studentInfo q in NAME)
            {
                combine = q.StudentID + " " + q.StudentName + " " + q.Marks + " " + q.Age + " " + q.Gender;
            }
            dataGridView1.DataSource = NAME.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var NAME = from cust in stu
                       orderby cust.Age ascending
                       select cust;
            string combine = "";

            foreach (studentInfo q in NAME)
            {
                combine = q.StudentID + " " + q.StudentName + " " + q.Marks + " " + q.Age + " " + q.Gender;
            }
            dataGridView1.DataSource = NAME.ToList();

        }
    }

}

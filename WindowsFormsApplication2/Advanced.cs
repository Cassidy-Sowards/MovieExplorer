using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Advanced : Form
    {
        private Form1 myParentForm = null;
        public Boolean submitClicked = false;
        public Advanced(Form1 mainformref)
        {
            myParentForm = mainformref;
            InitializeComponent();
        }

        public string getGenre1()
        {
            return textBox1.Text;
        }

        public string getGenre2()
        {
            return textBox2.Text;
        }

        public string getRating()
        {
            return textBox3.Text;
        }

        public string getReview()
        {
            return textBox4.Text;
        }

        public string getFirstYear()
        {
            return textBox5.Text;
        }

        public string getLastYear()
        {
            return textBox6.Text;
        }

        public string getKeyword()
        {
            return textBox7.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            myParentForm.dataGridView1.DataSource = Program.HwClient.searchMovies(textBox1.Text, textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text
                ,textBox7.Text
                );
            this.Close();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

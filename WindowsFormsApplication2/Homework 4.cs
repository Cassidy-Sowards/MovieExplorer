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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Hide();

            criteriaBox.SelectedIndex = 2;
      



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void criteriaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(criteriaBox.GetItemText(criteriaBox.SelectedItem).Equals("Director").ToString());
            if (criteriaBox.GetItemText(criteriaBox.SelectedItem) == "Director")
            {


                Hollywood.Director d = Program.HwClient.getDirector(textBox1.Text);
                dataGridView1.DataSource = d.movies;
                label11.Text = "Results for movies with director " + textBox1.Text;

            }

            else if (criteriaBox.GetItemText(criteriaBox.SelectedItem) == "Actor")
            {
                Hollywood.Actor a = Program.HwClient.getActor(textBox1.Text);
                dataGridView1.DataSource = a.movies;

                label11.Text = "Results for movies with actor " + textBox1.Text;
            }

            else if (criteriaBox.GetItemText(criteriaBox.SelectedItem) == "Title")
            {
                Boolean exfound = false;
                try
                {
                    dataGridView1.DataSource = Program.HwClient.searchMovies(null, null, null, null, null, null, textBox1.Text);
                }
                catch (Exception)
                {
                    label11.Text = "No Movie titles found with \" " + textBox1.Text + "\"";
                    exfound = true;
                }

                if (exfound == false)
                {
                    label11.Text = "Results for Movie Titles with \"" + textBox1.Text + "\"";
                }

                /* textBox3.Text += m.title;
                textBox4.Text += m.released;
                textBox5.Text += m.rating;
                textBox6.Text += m.genres;
                textBox7.Text += m.director;
                xtBox8.Text += m.review;
                dataGridView1.DataSource = m.actors; */

            }
            else if (criteriaBox.GetItemText(criteriaBox.SelectedItem) == "Genre")
            {
                Boolean exfound = false;
                try
                {
                    dataGridView1.DataSource = Program.HwClient.searchMovies(textBox1.Text, null, null, null, null, null, null);
                }
                catch (Exception)
                {
                    label11.Text = "No Movie titles found with genre " + textBox1.Text;
                    exfound = true;
                }

                label11.Text = "Movie Titles with genre " + textBox1.Text;

            }


 


        }

        private void criteriaBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(criteriaBox.GetItemText(criteriaBox.SelectedItem) == "Title"){
                label3.Show();
            }
            else
            {
                label3.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getPopularActors(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getPopularDirectors();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getPopularMovies();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getRatings();
            label11.Text = "Ratings Scale";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getReviews();
            label11.Text = "Possible Reviews";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.HwClient.getGenres();
            label11.Text = "Movie Genres";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Advanced form = new Advanced(this);
            form.Show();
            Console.WriteLine(form.getKeyword());
            
            

                Console.WriteLine("In if statement");
               dataGridView1.DataSource = Program.HwClient.searchMovies(form.getGenre1(), form.getGenre2(), form.getRating(), form.getReview(), form.getFirstYear(), form.getLastYear(), form.getKeyword());


        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Hollywood.Movie h = Program.HwClient.getMovie(textBox3.Text, textBox4.Text);
            textBox6.Text = h.genres.ToString();
            dataGridView2.DataSource = h.actors;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

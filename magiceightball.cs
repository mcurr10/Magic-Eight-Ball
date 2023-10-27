using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace magic8ball
{
    public partial class magiceightball : Form
    {
        private Random random = new Random();
        private List<string> answers = new List<string>();

        public magiceightball()
        {
            InitializeComponent();

            // Add Magic 8-Ball answers
            answers.Add("It is certain.");
            answers.Add("It is decidedly so.");
            answers.Add("Without a doubt.");
            answers.Add("Yes definitely.");
            answers.Add("You may rely on it.");
            // Middle ground answers
            answers.Add("As I see it, yes.");
            answers.Add("Most likely.");
            answers.Add("Outlook good.");
            answers.Add("Yes.");
            answers.Add("Signs point to yes.");
            answers.Add("Reply hazy, try again.");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            // No answers
            answers.Add("Don't count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful");


        }
        private void questionbox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            label1.Text = answers[index];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void magiceightball_Load(object sender, EventArgs e)
        {

        }
    }
}


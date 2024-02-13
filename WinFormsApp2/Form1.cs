namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int ROCK = 0;
        int PAPER = 1;
        int SCISSORS = 2;

        int wins = 0;
        int losses = 0;
        int ties = 0;


        int choice = -1;





        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice = ROCK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice = PAPER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = SCISSORS;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int opponet = Random.Shared.Next(ROCK, SCISSORS + 1);
            if (opponet == ROCK)
            {
                label1.Text = "Rock";
            }
            else if (opponet == PAPER)
            {
                label1.Text = "paper";
            }
            else if (opponet == SCISSORS)
            {
                label1.Text = "scissors";
            }

            if (opponet == ROCK && choice == PAPER)
            {
                wins++;
            }
            else if (opponet == PAPER && choice == SCISSORS)
            {
                wins++;
            } 
            else if (choice == SCISSORS && opponet == ROCK) 
            {
                wins++;
            }

            label2.Text = "Wins" + wins.ToString();

            if ( choice == ROCK && opponet == PAPER)
            {
                losses++;
            }
            else if (choice == PAPER && opponet == SCISSORS)
            {
                losses++;
            }
            if (choice == SCISSORS && opponet == ROCK)
            {
                losses++;
            }


            label3.Text = "losses" + losses.ToString();

         
            if (choice == ROCK && opponet == ROCK)
            {
                ties++;
            }
            else if (choice == PAPER && opponet == PAPER)
            {
                ties++;
            }
            if (choice == SCISSORS && opponet == ROCK)
            {
                ties++;
            }

            label4.Text = "ties" + ties.ToString();



        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

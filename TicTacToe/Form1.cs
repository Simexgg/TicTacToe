namespace TicTacToe
{
    public partial class Form1 : Form
    {


        bool turn = true;  // true = x turn    false = o turn
        int turncount = 0; // count turn


        public Form1()
        {
            InitializeComponent();
            this.Select();   // disable auto tab select
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Simon Guay Gozzi", " Tic Tac Toe Project.");
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;    //switch the text printed when button is pressed. for the next player
            if (turn)
            {
                b.Text = "X";
                b.BackColor = Color.CornflowerBlue;
            }            
                
            else
            {
                b.Text = "O";
                b.BackColor = Color.LightBlue;
            }
                

            turn = !turn;    //switch players turn 

            b.Enabled = false; // disable the possibility of repressing same button

            turncount++;  // tie condition

            winnercon();

        }

        private void winnercon()   // win condition for evry scenario
        {
            bool winner = false;

            //Horizontal
            
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
            }

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            //Vertical

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }

            //Diagonal

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A2.Enabled))
            {
                winner = true;
            }


            if (winner)
            {
                if(turncount>= 4)  //condition to fixed a issues i had when pressing A2 in the first 2 to 3 turn making a weird bug that i couldnt fix. really curious on what was causing it.( second square from the top row )
                {
                gameover();

                string win = "";

                if (turn)
                    win = "O";
                else
                    win = "X";

                MessageBox.Show("Players " + win + " Wins the match");   // win message
                }
            }
            else
            {
                if (turncount == 9)
                {
                    MessageBox.Show("  its a tied match"); // tied message
                }
            }
        }

        private void gameover()    // game is over, lock it into place by disableing button
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)   // reset the board for a new game
        {
            turn = true;
            turncount = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.LightSkyBlue;
                }
            }
            catch { }

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTac : Form
    {
        bool turn = true; //true = X's turn
        int steps = 0;
        int xwin = 0;
        int owin = 0;
        int draw = 0;
        public TicTac()
        {
            InitializeComponent();
            label1.Text = "";
        }


        private void button_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                label1.Text = "O's Turn";
            }
            else
            {
                b.Text = "O";
                label1.Text = "X's Turn";
            }
            b.Enabled = false;
            if (checkwin())
            {
                if (turn)
                {
                    MessageBox.Show("X WINS!", "Winner!");
                    xwin++;
                    setrecord();
                }
                else
                {
                    MessageBox.Show("O WINS!", "Winner!");
                    owin++;
                    setrecord();
                }
                reset();
            }
            else
            {
                steps++;
                
            }
            turn = !turn;
            if (steps==9)
            {
                MessageBox.Show("Its a Draw!", "Opps!");
                draw++;
                setrecord();
                reset();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Playing!", "Exiting!");
            Application.Exit();
        }

        private void reset()
        {
            steps = 0;
            button_reset();
           
        }
        private void button_reset()
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.ResetText();
            A2.ResetText();
            A3.ResetText();
            B1.ResetText();
            B2.ResetText();
            B3.ResetText();
            C1.ResetText();
            C2.ResetText();
            C3.ResetText();
        }

        private bool checkwin()
        {
            if ((A1.Text==A2.Text) && (A2.Text==A3.Text) && !A1.Enabled && !A2.Enabled && !A3.Enabled)
            {
                return true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled && !B2.Enabled && !B3.Enabled)
            {
                return true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled && !C2.Enabled && !C3.Enabled)
            {
                return true;
            }
            else if ((C1.Text == B1.Text) && (B1.Text == A1.Text) && !C1.Enabled && !A1.Enabled && !B1.Enabled)
            {
                return true;
            }
            else if ((C2.Text == B2.Text) && (B2.Text == A2.Text) && !C2.Enabled && !A2.Enabled && !B2.Enabled)
            {
                return true;
            }
            else if ((C3.Text == B3.Text) && (B3.Text == A3.Text) && !C3.Enabled && !A3.Enabled && !B3.Enabled)
            {
                return true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !B2.Enabled && !A1.Enabled && !C3.Enabled)
            {
                return true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !B2.Enabled && !A3.Enabled && !C1.Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void setrecord()
        {
            XBox.Text = xwin.ToString();
            OBox.Text = owin.ToString();
            DBox.Text = draw.ToString();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            xwin = 0;
            draw = 0;
            owin = 0;
            setrecord();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Pranshu Acharya", "About!");
        }
    }
}

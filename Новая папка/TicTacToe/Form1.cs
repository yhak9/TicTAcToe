using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string current_player; 
        int turn_count;        
        Button[,] buttons;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "";
            ResetGame();
        }
        private void Disabled_btn()
        {
            {
                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }
            }
        }

        private bool CheckRows()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text == current_player &&
                    buttons[i, 1].Text == current_player &&
                    buttons[i, 2].Text == current_player)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckColumns()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text == current_player &&
                    buttons[1,i].Text == current_player &&
                    buttons[2, i].Text == current_player)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckDiagonals()
        {
            if (buttons[0, 0].Text == current_player &&
                    buttons[1, 1].Text == current_player &&
                    buttons[2, 2].Text == current_player)
            {
                return true;
            }
            if (buttons[0, 2].Text == current_player &&
                    buttons[1, 1].Text == current_player &&
                    buttons[2, 0].Text == current_player)
            {
                return true;
            }
            return false;
        }
        private bool CheckForWinner()
        {
            return (CheckRows() || CheckColumns() || CheckDiagonals());
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Text = current_player;
            clickedButton.Enabled = false;
            turn_count++;

            if (CheckForWinner())
            {
                label2.Text = $"Игрок {current_player} выиграл!";
                Disabled_btn();
            }
            else if (turn_count == 9)
            {
                label2.Text = "Ничья!";
            }
            else
            {
                current_player = (current_player == "X") ? "O": "X";
                label3.Text = $"{current_player}";
            }
        }
        private void ResetGame()
        {
            current_player = "X";
            label3.Text = $"{current_player}";
            turn_count = 0;
            buttons = new Button[3, 3]
            {
                {button1,button2,button3},
                {button4,button5,button6},
                {button7,button8,button9}
            };
            foreach (Button btn in buttons)
            {
                btn.Text = string.Empty;
                btn.Enabled = true;
                btn.Click -= Button_Click;
                btn.Click += Button_Click;
            }
            label2.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}

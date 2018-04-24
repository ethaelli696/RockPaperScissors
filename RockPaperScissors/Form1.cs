using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// <summary>
/// A rock, paper, scissors game that utilizes basic methods
/// for repetitive tasks.
/// </summary>

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice, cpuChoice, winner;
        int wins = 0;
        int losses = 0;
        int ties = 0;
        int choicePause = 1000;
        int outcomePause = 3000;

        Random randGen = new Random();

        SoundPlayer jabPlayer = new SoundPlayer(Properties.Resources.jabSound);
        SoundPlayer gongPlayer = new SoundPlayer(Properties.Resources.gong);

        Image rockImage = Properties.Resources.rock168x280;
        Image paperImage = Properties.Resources.paper168x280;
        Image scissorImage = Properties.Resources.scissors168x280;
        Image winImage = Properties.Resources.winTrans;
        Image loseImage = Properties.Resources.loseTrans;
        Image tieImage = Properties.Resources.tieTrans;

        Point playerLocation;
        Point cpuLocation = new Point(520, 70);
        Point outcomeLocation = new Point(390, 5);

        Graphics g;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            playerLocation = new Point(this.Width / 2 - rockImage.Size.Width - 10, 70);
            cpuLocation = new Point(this.Width / 2 + 10, 70);
            outcomeLocation = new Point(this.Width / 2 - winImage.Size.Width/2);
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            winner = "scissors";

            g.DrawImage(rockImage, playerLocation);
            jabPlayer.Play();

            Thread.Sleep(choicePause);

            computerChoice();
            winnerChoose();

        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            winner = "rock";

            g.DrawImage(paperImage, playerLocation);
            jabPlayer.Play();

            Thread.Sleep(choicePause);

            computerChoice();
            winnerChoose();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            winner = "paper";

            g.DrawImage(scissorImage, playerLocation);
            jabPlayer.Play();

            Thread.Sleep(choicePause);

            computerChoice();
            winnerChoose();
        }

        public void winnerChoose()
        {
            if (playerChoice == cpuChoice)
            {
                gongPlayer.Play();

                g.DrawImage(tieImage, outcomeLocation);

                ties++;
                tiesLabel.Text = "Ties: " + ties;
            }
            else if (cpuChoice == winner)
            {
                gongPlayer.Play();

                g.DrawImage(winImage, outcomeLocation);

                wins++;
                winsLabel.Text = "Wins: " + wins;
            }
            else
            {
                gongPlayer.Play();

                g.DrawImage(loseImage, outcomeLocation);

                losses++;
                lossesLabel.Text = "Losses: " + losses;
            }
            Thread.Sleep(outcomePause);
            Refresh();
        }

        public void computerChoice()
        {
            int randValue = randGen.Next(1, 4);

            if (randValue == 1)
            {
                cpuChoice = "rock";
                g.DrawImage(rockImage, cpuLocation);
            }
            else if (randValue == 2)
            {
                cpuChoice = "paper";
                g.DrawImage(paperImage, cpuLocation);
            }
            else
            {
                cpuChoice = "scissors";
                g.DrawImage(scissorImage, cpuLocation);            
            }

            jabPlayer.Play();
            Thread.Sleep(choicePause);
        }
    }
}
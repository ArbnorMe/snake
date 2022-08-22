using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace irgendeinTollesSpiel
{
    public partial class game : Form
    {
        // Geschrieben von Arbnor Memedi HIT11
        // Projektstart 08.03.2022

        Random random = new Random();
        Rectangle snake = new Rectangle(400, 200, 20, 20); // Snake spawn Position
        List<Rectangle> food = new List<Rectangle>();
        List<Rectangle> snakeLeange = new List<Rectangle>();
        int objectSize = 20; // Groesse von Snake und dem Essen
        int snakeSpeed = 3; // Geschwindigkeit
        double punkte = 0;
        // Ob Tasten gedrueckt werden
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        // ---

        public game()
        {
            // Nicht leaschen! .
            InitializeComponent();
        }

        void game_Paint(object sender, PaintEventArgs e)
        {
            // --Zeichnen der Objekte__
            // "snake"
            e.Graphics.FillRectangle(Brushes.DarkGreen, snake);

            // "food"
            for (int i = 0; i < food.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.Red, food[i]);
            }
         }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            // Ausgabe der X Kordinate vom Ball
            ballX.Text = Convert.ToString(snake.X);
            // Ausgabe der Y Kordinate vom Ball
            ballY.Text = Convert.ToString(snake.Y);

            // Schwanz bewegung
            //snakeSchwanzBewegung();

            // Snake bewegung (WASD und Pfeiltasten)
            if (goUp == true)
            {
                snake.Y = snake.Y - snakeSpeed;
                eingabe_ausgabe.Text = "Oben";
            } else
            if (goDown == true)
            {
                snake.Y = snake.Y + snakeSpeed;
                eingabe_ausgabe.Text = "Unten";
            } else
            if (goLeft == true)
            {
                snake.X = snake.X - snakeSpeed;
                eingabe_ausgabe.Text = "Links";
            } else
            if (goRight == true)
            {
                snake.X = snake.X + snakeSpeed;
                eingabe_ausgabe.Text = "Rechts";
            }

            // Ueberprueft ob sich Snake an denn Rand befindet.
            if (snake.Y < 0)
            {
                snake.Y = ClientRectangle.Height;
            }

            if (snake.Y > ClientRectangle.Height)
            {
                snake.Y = 0;
            }
            if (snake.X < 0)
            {
                snake.X = ClientRectangle.Width;
            }
            if (snake.X > ClientRectangle.Width)
            {
                snake.X = 0;
            }

            snakeWillEssen();

            Refresh();
        }

        void foodSpawn()
        {
            int clientsizeX = random.Next(0, ClientSize.Width);
            int clientsizeY = random.Next(0, ClientSize.Height);
            food.Add(new Rectangle(clientsizeX, clientsizeY, objectSize, objectSize));
        }

        // "snake" weachst
        void snakeWeachst()
        {
            for (int i = 0; i < snakeLeange.Count; i++)
            {
                snakeLeange[i] = snake;
            }
        }

        private void foodTimer_Tick(object sender, EventArgs e)
        {
            foodSpawn();
            Refresh();
        }

        //Ueberpruefung ob Snake ein Food Objekt beruehrt.
        private void snakeWillEssen()
        {
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i].IntersectsWith(snake)) // Uberprueft on "snake" "food" beruehrt.
                {
                    food.RemoveAt(i);
                    i++;
                    punkte = punkte + 1;
                    punkteAnzeige.Text = Convert.ToString(punkte); // Fuegt einen Punkt in der "punktAnzeige" dazu.

                    Refresh();
                }
            }
        }

        private void snakeSchwanzBewegung()
        {
            int anzahl = snakeLeange.Count - 1;
            while (0 != anzahl)
            {

            }
        }

        // Ueberpruefung ob Knopf nicht gedrueckt wurde.
        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            // KeyUp
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            // KeyDown
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            // KeyLeft
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            // KeyRight
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
        }


        // Ueberpruefung ob Knopf gedrueckt wurde.
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            // KeyUp
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;

            }
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            // KeyDown
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            // KeyLeft
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            // KeyRight
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
        }
    }
}

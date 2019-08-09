using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

/* https://www.youtube.com/watch?v=i6W-aGhlq7M */
// -> dieser Link war überaus hilfreich, für ein Spiel, um die Eisbären zu retten ;-)
// 31.05.2018


namespace Eisbären
{
    public partial class Snake : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;


        private List<Circle> Snakeobject = new List<Circle>();
        private Circle food = new Circle();
        SpieleLogin fh;
        public Snake(SpieleLogin aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();

            // Set settings to default
            new Settings();

            // Set game speed and start timer
            timersnake.Interval = 1000 / Settings.Speed;
            timersnake.Tick += UpdateScreen;
            timersnake.Start();

            //Start New Game
            StartGame();

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for GameOver
            if (Settings.GameOver == true)
            {
                //Check if Enter is pressed 
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pictureBoxSnake.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snakeobject.Count - 1; i >= 0; i--)
            {
                // Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snakeobject[i].X++;
                            break;
                        case Direction.Left:
                            Snakeobject[i].X--;
                            break;
                        case Direction.Up:
                            Snakeobject[i].Y--;
                            break;
                        case Direction.Down:
                            Snakeobject[i].Y++;
                            break;
                    }

                    // Get maximum X and Y Pos
                    int maxXPos = pictureBoxSnake.Size.Width / Settings.Width;
                    int maxYPos = pictureBoxSnake.Size.Height / Settings.Height;

                    // Detect Collision with game borders 
                    if (Snakeobject[i].X < 0 || Snakeobject[i].Y < 0
                        || Snakeobject[i].X >= maxXPos || Snakeobject[i].Y >= maxYPos)
                    {
                        Die();
                    }

                    // Detect collission with body
                    for (int j = 1; j < Snakeobject.Count; j++)
                    {
                        if (Snakeobject[i].X == Snakeobject[j].X && 
                            Snakeobject[i].Y == Snakeobject[j].Y )
                        {
                            Die();
                        }
                    }

                    // Detect collision with food piece
                    if (Snakeobject[0].X == food.X && Snakeobject[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    // Move body
                    Snakeobject[i].X = Snakeobject[i - 1].X;
                    Snakeobject[i].Y = Snakeobject[i - 1].Y;
                }
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            // Add circle to body
            Circle food = new Circle();
            food.X = Snakeobject[Snakeobject.Count - 1].X;
            food.Y = Snakeobject[Snakeobject.Count - 1].Y;

            Snakeobject.Add(food);

            // Update Score
            Settings.Score += Settings.Points;
            label2.Text = Settings.Score.ToString();

            GenerateFood();
        }


        private void StartGame()
        {
            labelgameover.Visible = false;

            // Set settings to default
            new Settings();

            // Create new player object
            Snakeobject.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snakeobject.Add(head);

          //  try
        //        {
        //            con.Open();

            //            int x = 100;

            //            cmd.CommandText = "UPDATE Person SET Spendenbetrag = '" + textBoxSpende.Text +
            //                "' WHERE " + "ID = " + spnummer[listBox2.SelectedIndex];

            //            MessageBox.Show(cmd.CommandText);

            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Spendenbetrag geändert");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);

            //            MessageBox.Show("Bitte einen Datensatz aus der Listbox auswählen, sofern keiner vorhanden ist, bitte zunächst einen neuen" +
            //                "Spendenaccount anlegen");
            //        }
            //        con.Close();

            label2.Text = Settings.Score.ToString();
            GenerateFood();

        }

        // Place random food game
        private void GenerateFood()
        {
            int maxXPos = pictureBoxSnake.Size.Width / Settings.Width;
            int maxYPos = pictureBoxSnake.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);

        }

        private void pictureBoxSnake_Paint(object sender, PaintEventArgs e)
        {
            Graphics snake = e.Graphics;

            if(!Settings.GameOver)
            {
                // Set colour of snake
                Brush snakeColour;

                // Draw Snake
                for (int i = 0; i < Snakeobject.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black; // Draw head
                    else
                        snakeColour = Brushes.Green; // rest of body

                    // Draw Snake
                    snake.FillEllipse(snakeColour,
                        new Rectangle(Snakeobject[i].X * Settings.Width,
                                      Snakeobject[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    // Draw food
                    snake.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                                food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress Enter to try again";
                labelgameover.Text = gameOver;
                labelgameover.Visible = true;
            }
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Snake_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            string Nachname, Vorname;

            Nachname = fh.Controls["textBoxNachnameSpiel"].Text;

            Vorname = fh.Controls["textBoxVornameSpiel"].Text;
        }

        //private void Snake_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        // Then Enter key was pressed
        //        try
        //        {
        //            con.Open();

        //            int x = 100;

        //            cmd.CommandText = "UPDATE Person SET Spendenbetrag = '" + textBoxSpende.Text +
        //                "' WHERE " + "ID = " + spnummer[listBox2.SelectedIndex];

        //            MessageBox.Show(cmd.CommandText);

        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Spendenbetrag geändert");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);

        //            MessageBox.Show("Bitte einen Datensatz aus der Listbox auswählen, sofern keiner vorhanden ist, bitte zunächst einen neuen" +
        //                "Spendenaccount anlegen");
        //        }
        //        con.Close();







        //    }
    }
    }


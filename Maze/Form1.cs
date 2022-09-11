using System;
using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {

        Labirint labirint;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame()
        {
            labirint = new Labirint(this, 40, 20);

            labirint.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                labirint.Move(MazeObject.MoveDirection.UP);
            }
            else if (e.KeyCode == Keys.S)
            {
                labirint.Move(MazeObject.MoveDirection.DOWN);
            }
            else if (e.KeyCode == Keys.A)
            {
                labirint.Move(MazeObject.MoveDirection.LEFT);
            }

            else if (e.KeyCode == Keys.D)
            {
                labirint.Move(MazeObject.MoveDirection.RIGHT);
            }
        }
    }
}

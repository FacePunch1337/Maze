using System;
using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR, AID };
        public enum MoveDirection { UP, DOWN, LEFT, RIGHT };


        public Bitmap[] images = {new Bitmap(@"C:\Users\Stus\Desktop\s\pics\hall.png"),
            new Bitmap(@"C:\Users\Stus\Desktop\s\pics\wall.png"),
            new Bitmap(@"C:\Users\Stus\Desktop\s\pics\medal.png"),
            new Bitmap(@"C:\Users\Stus\Desktop\s\pics\enemy.png"),
            new Bitmap(@"C:\Users\Stus\Desktop\s\pics\player.png")};

        public MazeObjectType type;
        public int width;
        public int height;
        private Image _texture;
        public Image texture
        {
            get
            {
                return images[(int)type];
            }
        }

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            _texture = images[(int)type];
        }

       



    }
}

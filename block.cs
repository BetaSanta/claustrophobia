using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace claustrophobia
{
    static class block
    {
        public static bool f = false;

        /// <summary>
        /// Ограничение справа
        /// </summary>
        static public void methodRight(PictureBox block, PictureBox player)
        {
            if (player.Right > block.Left && player.Left < block.Right - player.Width && player.Bottom < block.Bottom && player.Bottom > block.Top) 
            {
                PlayerClass.right = false;
            }
        }

        /// <summary>
        /// Ограничение слева 
        /// </summary>
        static public void methodLeft(PictureBox block, PictureBox player)
        {
            if (player.Left < block.Right && player.Right > block.Left + player.Width && player.Bottom < block.Bottom && player.Bottom > block.Top) 
            {
                PlayerClass.left = false;
            }
        }

        /// <summary>
        /// Ограничение сверху
        /// </summary>
        static public void methodTop(PictureBox block, PictureBox player)
        {
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                PlayerClass.jump = false;
                PlayerClass.Force = 0;
                player.Top = block.Location.Y - player.Height;
            }
        }

        /// <summary>
        /// Ограничение головы
        /// </summary>
        static public void methodHead(PictureBox block, PictureBox player)
        {
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top - block.Bottom <= 10 && player.Top - block.Top > -10)
            {
                PlayerClass.Force = -1;
            }
        }

        /// <summary>
        /// Специальное ограничение по правому боку
        /// </summary>
        static public void methodRight2(PictureBox block, PictureBox player)
        {
            if (player.Right > block.Left && player.Left < block.Right - player.Width / 2 && player.Bottom > block.Top)
            {
                PlayerClass.right = false;
            }
        }

        static public void methodLeft2(PictureBox block, PictureBox player)
        {
            if (player.Left < block.Right && player.Right > block.Left + player.Width / 2 && player.Bottom > block.Top)
            {
                PlayerClass.left = false;
            }
        }
    }
}

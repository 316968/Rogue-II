using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Rogue_II
{
    class Enemy
    {
        Canvas canvas = new Canvas();
        Window window = new Window();
        Point pos = new Point();
        Rectangle enemyRectangle = new Rectangle();
        int hp;
        int maxHP;
        int strength;
        int armour;
        int level;
        int enemyType;
        bool alive = true;
        public Enemy (Canvas canvas, Window window)
        {
            enemyRectangle = new Rectangle();
            enemyRectangle.Height = 10;
            enemyRectangle.Width = 10;
            enemyRectangle.Fill = Brushes.Red;
            canvas.Children.Add(enemyRectangle);
        }

        public void move()
        {

        }
        
    }
}

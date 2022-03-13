using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine rightline = new HorizontalLine(0,118,0,'+');
            VerticalLine upLine = new VerticalLine(0, 29, 0, '+');
            HorizontalLine leftline = new HorizontalLine(0, 118, 29, '+');
            VerticalLine downLine = new VerticalLine(0, 29, 118, '+');
            rightline.Drow();
            upLine.Drow();
            leftline.Drow();
            downLine.Drow();

            Point p = new Point(10, 7, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine ();    
        }

        
    }
}

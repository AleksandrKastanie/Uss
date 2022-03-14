using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss
{
    internal class Figure
    {
        protected List<Point> plist;
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}

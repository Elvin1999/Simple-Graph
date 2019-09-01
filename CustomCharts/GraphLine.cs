using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomCharts
{
   public class GraphLine
    {
        public int OverScore { get; set; }
        public double Data { get; set; }
        public double Height { get; set; }
        public int StepX { get; set; }
        public Point Start { get; set; }
        public Point Last { get; set; }
        public Point GetLastPoint()
        {
            var percent =  Data / OverScore*100;
            var value = Height * (int)percent / 100;
            var yLast = 600 - (int)value+20;
            var xLast = Start.X + StepX;
            Point lastPoint = new Point()
            {
                 Y=yLast,
                  X=xLast
            };
            return lastPoint;
        }
    }
}

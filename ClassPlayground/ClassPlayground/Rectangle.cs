using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public Rectangle(int height,int width)
        {
            this.height = height;
            this.width = width;
        }
        public void CalculateArea()
        {
            Console.WriteLine("The area of the rectangle is: "+ width*height+"j^2");
        }
        public void CalculateAspectRatio()
        {
            Console.WriteLine("The aspect ratio of this rectangle is: "+ width + "/" + height);
            if (width > height)
            {
                Console.WriteLine("This rectangle is WIDE.");
            }
            else if (height > width)
            {
                Console.WriteLine("This rectangle is TALL.");
            }
            else
            {
                Console.WriteLine("This rectangle is a SQUARE.");
            }
        }
        public void ContainsPoint(float x,float y)
        {
            if (x<0 || y<0)
            {
                Console.WriteLine("NO, the ractangle does not contain this point.");
            }
            else
            {
                if (x < width && y < height)
                {
                    Console.WriteLine("YES, the rectangle contains this point.");
                }
                else
                {
                    Console.WriteLine("NO, the ractangle does not contain this point.");
                }
            }
            
        }
    }
}

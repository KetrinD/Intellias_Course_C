using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Of_Objects
{
    class Table
    {
        private int width, height;

        public Table()
        {
        }
        public Table(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            set { width = value; }
            get { return width; }
        }
        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public void ShowData()
        {
            //Console.WriteLine("Width: {0}, Heigth: {1}", width, height);  
            // or
            Console.WriteLine($"width: {width},  height: {height}");
        }
    }


}
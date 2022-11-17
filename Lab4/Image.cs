using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Image : Subject
    {
        int height;
        int width;
        int x;
        int y;
        public Image(int height, int width, int x, int y)
        {
            this.height = height;
            this.width = width;
            this.x = x;
            this.y = y;
        }
        public int getHeight()
        {
            return height;
        }
        public int getWidth()
        {
            return width;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void draw()
        {
            Console.Clear();
            for (int i = 0; i < y; i++)
                Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width + x; j++)
                {
                    if (j >= x)
                    {
                        if((i+j)%2==0)
                            Console.Write("~");
                        else Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public void move(int x, int y)
        {
            Console.Clear();
            for (int i = 0; i < y; i++)
                Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width + x; j++)
                {
                    if (j >= x)
                    {
                        if ((i + j) % 2 == 0)
                            Console.Write("~");
                        else Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}

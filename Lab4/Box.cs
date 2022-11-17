using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Box : Subject
    {
        Image img;
        int height;
        int width;
        int x;
        int y;
        bool click;
        public Box(int x, int y)
        {
            img = new Image(5, 10, x, y);
            height = img.getHeight();
            width = img.getWidth();
            this.x = x;
            this.y = y;
            click = false;
        }
        public void setClick(bool click)
        {
            this.click = click;
        }
        public bool getClick()
        {
            return click;
        }
        public void draw()
        {
            if (click)
                img.draw();
            else
            {
                Console.Clear();
                for (int i = 0; i < y; i++)
                    Console.WriteLine();
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width + x; j++)
                    {
                        if (j >= x)
                            Console.Write("*");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            }
        }

        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            img.setXY(x, y);
            if (click)
                img.move(x, y);
            else
            {
                Console.Clear();
                for (int i = 0; i < y; i++)
                    Console.WriteLine();
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width + x; j++)
                    {
                        if (j >= x)
                            Console.Write("*");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}

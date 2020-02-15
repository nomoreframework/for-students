using System;

namespace Vika
{
   public struct Point
    {
        public int x;
        public int y;
    }
   public  struct Robot
    {
        public Point start_point;
        public Point end_point;
        public char go_up, go_down, go_left, go_right;
        public Robot (Point start, Point end, char up, char down, char left, char righ)
        {
            start_point = start;
            end_point = end;
            go_up = up;
            go_down = down;
            go_left = left;
            go_right = righ;
        }
        public int Count_Of_Steps(ref Point start_point, ref Point end_point)
        {
            int count_of_steps;
            if((start_point.x + start_point.y) > (end_point.x + end_point.y))
            {
                count_of_steps = (start_point.x + start_point.y) - (end_point.x + end_point.y);
                return count_of_steps;
            }
            else if((start_point.x + start_point.y) < (end_point.x + end_point.y))
            {
              count_of_steps =  (end_point.x + end_point.y) - (start_point.x + start_point.y);
                return count_of_steps;
            }
            return 0;
        }
        public char[] Move()
        {
            int steps_count = Count_Of_Steps(ref start_point, ref end_point);
            char[] steps = new char[steps_count];
            //логика простая , записываем в масив буквы соответствующие итерации ++ для движения по одной из координат
            return steps;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}

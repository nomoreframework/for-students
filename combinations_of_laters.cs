using System;
using System.Threading;

namespace combinations_of_laters
{
    class Program
    {
        
      public static void Main(string[] args)
        {
           const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
           char [] get_index_from_str =  Alphabet.ToCharArray();
           Console.WriteLine(" Please write quantity of laters from alphabet");
           int M = Convert.ToInt32(Console.ReadLine());
          
           Console.WriteLine("Please write length word");
           int N = Convert.ToInt32(Console.ReadLine());

            int count_laters = N; 
            int number_system = M;
            int count = (int)Math.Pow(number_system,count_laters);
            count -= 1;
            while (count > -1)
            {
                Console.Write(" " + count);
                Console.ForegroundColor = ConsoleColor.Blue;

             move_arr(count, number_system, count_laters,get_index_from_str);
             Console.WriteLine();
             count--;   
          //   Thread.Sleep(100);
            }
        }
            static int []  move_arr (int count, int number_system, int count_laters, char [] get_index_from_str)
            {
                int [] idexes = new int [count_laters];
                for (int i = 0; i < count_laters; i++)
                {
                int position = count_laters -i -1;
                int level = (int)Math.Pow(number_system,position);
                int index = count / level;

                idexes[i] = index;
                count -= index * level;
                }
                    for (int j = 0; j < count_laters;j++)
                    {
                        Console.Write(" " + get_index_from_str[idexes[j]]);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" #");

                  return idexes;
            }
            
    }
}

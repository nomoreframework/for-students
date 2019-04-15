using System;

namespace Jaget_array_Sort
{
    class Program 
    {
     public static void Main(string[] args)
        {
             int [][] arr_Taxi = new int [][]
            {
                new int [] {300, 120, 460, 340, 210},
                new int [] {110, 340, 540},
                new int [] {100},
                new int [] {235, 459, 530, 35, 65, 320, 1000, 470},
                new int [] { 345,765,450, 270},
                new int [] {100, 500,1100,12},
                new int [] {310, 270},
                new int [] {245, 180, 950, 640, 997, 560},
            };
                int part_left = 0;
                int part_riht = arr_Taxi.Length - 1;
                              
                 Quick_Sort(arr_Taxi,  part_left,  part_riht);
                 to_the_highest_revenue(arr_Taxi);
                    for (int ind = 0; ind < arr_Taxi.Length; ind++)
                    {
                        for (int inj = 0;inj < arr_Taxi[ind].Length;inj++)
                        {
                            Console.Write(" " + arr_Taxi[ind][inj]);
                        }
                        Console.WriteLine();
                    }
        }                
                     static int [][] to_the_highest_revenue(int[][] arr_Taxi)
                     {
                                int total_sum = 0;
                                int total_sum1 = 0;
                         for (int i = 1; i < arr_Taxi.Length; i++)
                         {
                           if (arr_Taxi[i].Length == arr_Taxi[i - 1].Length)
                          {
                              for (int j = 0; j < arr_Taxi[i].Length; j++)
                            {
                                total_sum = total_sum + arr_Taxi[i][j];
                                total_sum1 = total_sum1 + arr_Taxi[i - 1][j];
                            }  

                          
                            
                         
                              if (total_sum > total_sum1)
                            {
                                int [] arr_temp = new int [i];
                                int [] arr_temp1 = new int [i];
                                arr_temp = arr_Taxi[i];
                                arr_temp1 = arr_Taxi[i - 1];
                                arr_Taxi[i - 1] = arr_temp;
                                arr_Taxi[i] = arr_temp1;
                            }
                          
                           }
                         
                         }   
                                return arr_Taxi;
                          
                     }
         
          
               static void Quick_Sort(int[][] arr_Taxi, int part_left, int part_riht)
              {
                  int pivot, pivot_index, index;
                  pivot_index = Find_Pivot(arr_Taxi, part_left, part_riht);
                  if(pivot_index != -1)
                  {
                      pivot = arr_Taxi[pivot_index].Length;
                      index = Part(arr_Taxi, part_left,  part_riht, pivot);
                      Quick_Sort(arr_Taxi, part_left, index -1);
                      Quick_Sort(arr_Taxi, index,part_riht);
                  }
                  
              }
              static int Find_Pivot( int[][] arr_Taxi, int part_left, int part_riht)
              {
                  int i;
                  int num_before = arr_Taxi[part_left].Length;
                    for ( i = part_left + 1;i <= part_riht;i++)
                    {
                        if (arr_Taxi[i].Length > num_before) return i;
                        else if (arr_Taxi[i].Length < num_before) return part_left;
                    }
                  return -1;
              }
              static int Part(int [][] arr_Taxi, int part_left, int part_riht,  int pivot)
              {
                  int [] temp;
                  while (true)
                  {
                      while (arr_Taxi[part_left].Length  < pivot) part_left++;
                      while (arr_Taxi[part_riht].Length  >= pivot) part_riht--;
                        if (part_left > part_riht) break;
                         temp = arr_Taxi[part_left];
                           arr_Taxi[part_left] = arr_Taxi[part_riht];
                            arr_Taxi[part_riht] = temp;
                  }
                    return part_left;

              }
              
    }
}

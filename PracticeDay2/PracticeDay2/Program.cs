using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //using var instead of  specific data type
            var a = 2;
            var b = 3.334;
            var c = "HI Ayon";

            Console.WriteLine("Int : "+ a );
            Console.WriteLine("Double : "+ b);
            Console.WriteLine("String : " + c);

            //Jagged Array

            int[][] jg = new int[4][];
            jg[0] = new int[] { 1, 2, 3, 4 };
            jg[1] = new int[] {4, 5, 6 };
            jg[2] = new int[] { 7 };
            jg[3] = new int[] {8, 9 };

            for( int i = 0; i < jg.Length; i++)
            {
                for( int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Jagged Array With taking input

            int n;
            Console.Write("Enter Number of Arrays you wanna input : ");
            n = int.Parse(Console.ReadLine());

            int[][] jg2 = new int[n][];
            
            for( int i = 0;i < jg2.Length; i++)
            {
                Console.Write("Input size of array [" + i + "]  : ");
                int s;
                s = int.Parse(Console.ReadLine());
                jg2[i] = new int[s]; 
                for(int j = 0; j < s; j++)
                {
                    jg2[i][j] = int.Parse(Console.ReadLine());
                }

            }


            for (int i = 0; i < jg2.Length; i++)
            {
                for (int j = 0; j < jg2[i].Length; j++)
                {
                    Console.Write(jg2[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}

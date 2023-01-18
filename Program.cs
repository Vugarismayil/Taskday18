using System;


namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
            //Task1
            //int[] nums = { 5, 1, 9, 7, 8, 3, 8, 24 };
            //int a = finminnumber(nums);
            //Console.WriteLine(finminnumber(nums));

            //Task2
            //string text1 = "tester";
            //char cr = 'r';
            //Console.WriteLine(textfindcharN(text1, cr)); 

            //Task3
            //int[] number = {1,5,6,745,84,5,4,46,8,47,4,6,};
            //int find = 745;
            //    Console.WriteLine(numberindexfinder(number , find));

            //Task4
            //string text = "hello";
            //Console.WriteLine(text();

            //Task 5
            string test = "word";
            char[] cr = { '1','2','3','4','5','6','7','8','9','0'};
            Console.WriteLine(numxfind(test));

        }
        //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
        static int finminnumber(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];

                }
            }
            return min;
        }
        //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
        static int textfindcharN(string text, char cr)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == cr)
                {
                    count++;
                }

            }
            return count;
        }
        //Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
        
        static int numberindexfinder(int[]arr , int finder)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (finder == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        //- Verilmiş yazını əksinə çevirən metod(misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
        static string text (string texts)
        {
            string text = "";
            for(int i = texts.Length-1; i>=0; i--)
            {
                text += texts[i];
            }
            return text;
        }
        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool numxfind(string textt)
        {
            char[] cr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < textt.Length; i++)
            {
                for (int k = 0; k < cr.Length; k++)
                {
                    if (cr[k] == textt[i])
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}

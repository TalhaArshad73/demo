using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_serch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 2, 4, 9, 13, 16, 6, 3, 0 };
            int[] array = new int[5];
            Program obj = new Program();
            Console.WriteLine("Enter Values In Array");
            for (int i = 0; i < array.Length; i++ )
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter Value");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Locaton:\t" + obj.Bsearch(array, value));
            Console.WriteLine("Location:-  " + obj.recursion(array,0,array.Length-1,value));
            Console.ReadLine();
           
        }

        public int Bsearch(int [] array,int value)
        {
            int lb, ub, mid;
            lb = 0;
            ub = array.Length - 1;
            do
            {
                mid = ub + lb / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    ub = mid - 1;
                }
                else
                {
                    lb = mid + 1;
                }                
            } while (ub > lb);
            return 0;
        }
        public int recursion(int[] array, int lb, int ub, int value)
        {
            int mid;
            if (ub >= lb)
            {
                mid=(ub+lb)/2;
                if(array[mid]==value){
                    return mid;
                }
                else if (array[mid] > value)
                {
                    ub = mid + 1;
                }
                else
                {
                    lb = mid - 1;
                }

              return  recursion(array, lb, ub, value);
            }
            return -1;
        }
    
    }

}

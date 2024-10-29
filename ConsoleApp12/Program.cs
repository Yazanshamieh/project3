using System;
using System.Collections.Generic;
using System.Security.Cryptography;
internal class Program
{
    
    class serch<T> where T : IComparable<T>
    {
        public  void Sorting(T[]arry) {

            for (int i = 0; i < arry.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arry.Length; j++)
                {
                    if (arry[min].CompareTo(arry[j])>0)
                    {
                        min = j;
                    }
                }
                T temp = arry[i];
                arry[i] = arry[min];
                arry[min] = temp;
            }
        }
        public  int Serch(T[]arry,T key,int low,int high) {
            if (low <= high)
            {
                int mid = (low + high) / 2;


                if (arry[mid].Equals(key))
                {
                    return mid;
                }
                if (arry[mid].CompareTo(key) < 0) { return Serch(arry, key, mid + 1, high); }
                else  { return Serch(arry, key, low, mid - 1); }
            }
             return -1;
        }
        public int Serch2(T[] arry, T key)
        {

            int low = 0;
            int high = arry.Length-1;
           
            while (low<=high)
            {
                int mid = (low + high) /2;
                if (arry[mid].Equals(key))
                {
                    return mid;
                }
                if (arry[mid].CompareTo(key) > 0)
                {
                    high = mid - 1;
                    
                }
               else
                { low = mid + 1; }

            }
            return -1;
        }
        public void print(int result) {
            if (result != -1)
            {
                Console.WriteLine($" your item in index:{result}");

            }
            else
            {
                Console.WriteLine($"your item not found:{result}");
            }
            Console.WriteLine("___________________________");
        }
    }
    private static void Main(string[] args)
    {
        int opation;
        do
        {
            do
            {
                Console.WriteLine("1_for serching\n2_exit");
                opation = int.Parse(Console.ReadLine());
            } while (opation <= 0||opation>3);
            if (opation==2)
            {
                break;
            }
            Console.WriteLine("_______________________");
        serch<int> t = new serch<int>();
        int[]arry=new int[9];
        Random n=new Random();
        for (int i = 0; i < arry.Length; i++)
        {
            arry[i] = n.Next(1, 15);
        }
        t.Sorting(arry);
        foreach (var item in arry)
        {
            Console.WriteLine(item);
        }
        int num;
            
                Console.WriteLine("enter number");
                num = int.Parse(Console.ReadLine());
       
        int low = 0;
        int high = arry.Length-1;
        int result = t.Serch(arry, num, low, high);
        t.print(result);
        result = t.Serch2(arry, num);
        t.print(result);
        } while (opation==1);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lstPeople = new List<People>
            //{
            //    new People{ Name = "Andres", Age = 30, Genre = 'M' , Relatives = new List<People>
            //        {
            //            new People{ Name = "Mara", Age = 4, Genre = 'F' },
            //            new People{ Name = "Tony", Age = 1, Genre = 'M' }
            //        }
            //    },
            //    new People{ Name = "Natalia", Age = 26, Genre = 'F' },
            //    new People{ Name = "Camilo", Age = 15, Genre = 'M' , Relatives = new List<People>
            //        {
            //            new People{ Name = "Max", Age = 2, Genre = 'M' },
            //            new People{ Name = "Michi", Age = 7, Genre = 'M' }
            //        }},
            //    new People{ Name = "Tatiana", Age = 21, Genre = 'F' }
            //};

            //PrintPeople(lstPeople);
            // var fact = Fact(4);
            // Imprimir(5);

            //int[] array = { 312, 614, 88, 22, 54 };
            //var result = SortArray(array, array.Length); // 312, 88, 22, 54, 614


        }

        public static void PrintPeople(List<People> people)
        {
            if (people == null) return;
            foreach (People item in people)
            {
                Console.WriteLine("Name: {0}, age: {1}, Genre: {2}", item.Name, item.Age, item.Genre);
                PrintPeople(item?.Relatives);
            }
        }

        public static int Fib(int n)
        {
            int result = 0;

            if (n <= 1) result = 1;

            if(n > 1)
                result = Fib(n - 1) + Fib(n - 2);

            return result;
        }
        public static int Fact(int n)
        {
            if (n == 1) 
                return 1;

            return n * Fact(n - 1);
        }

        public static void Imprimir(int x)
        {
            if (x > 0)
            { 
                Console.WriteLine(x);
                Imprimir(x - 1);
            }
        }

        public static int[] SortArray(int [] array, int len)
        {
            if (len == 1) return array;
            for (int index = 0; index < len - 1; index++)
            {
                if(array[index] > array[index + 1])
                {
                    int aux = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = aux;
                }
            }

            SortArray(array, len - 1);

            return array;
        }
    }

    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Genre { get; set; }

        public List<People> Relatives { get; set; }
    }


    public class Person
    {
        public string Name { get; set; }
        public int t { get; set; }
    }

    public class Town
    {
        public int t { get; set; }
        public string Name { get; set; }
    }
}

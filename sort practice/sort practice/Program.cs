using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_practice
{
    class Program
    {

        /*Q. Write an algorithm to create a new sorted array called ageGrThn35 in descending order of age 
        from the given array:

        int[] ages = {12,15,10,9,90,34,28,89,23,21,56,34,92,11,2,4,66,78,88,99,24};

        Required Output in Console:

        99
        92
        90
        89
        88
        78
        66
        56

        Then Change the Value of ages[0] to 100:

        ages[0]=100;

        and create a new sorted array called ageGrThn35 in decending order of age

        Required Output in Console:

        100
        99
        92
        90
        89
        88
        78
        66
        56
         */
        static void Main(string[] args)
        {
            int[] ages = { 12, 15, 10, 9, 90, 34, 28, 89, 23, 21, 56, 34, 92, 11, 2, 4, 66, 78, 88, 99, 24 };
            int[] ages2 = new int[ages.Length];

            Array.Sort(ages);
            Array.Reverse(ages);

            for (int i = 0; i < ages2.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
            Console.WriteLine("");

            var test = from age in ages
                       where age > 35
                       orderby age descending
                       select age;

            ages[ages.Length - 1] = 100;

            foreach (var age in test)
            {
                Console.WriteLine(age);
            }

            var test2 = ages.Where(age => age > 35).OrderByDescending(age => age).Select(age => age);

            var animalList = new List<Animal>()
            {
                new Animal { Name="German Shepherd",Height=25,Weight=77},
                new Animal { Name="Chihuahua",Height=30,Weight=200},
                new Animal{Name="Saint Bernard",Height=30,Weight=200}
            };
            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;
            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}lbs", dog.Name, dog.Weight);
            }
            
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };
            var dogWithSpaceInName = from dog in dogs
                                     where dog.Contains(" ")
                                     select dog;
            var dogWithSpaceInName_lambda = dogs.Where(dog => dog.Contains(" ")).Select(dog => dog);
            foreach (var dog in dogWithSpaceInName)
            {
                Console.Write(dog + " ; ");
            }
            Console.WriteLine();
            foreach (var dog in dogWithSpaceInName_lambda)
            {
                Console.WriteLine(dog + " ; ");
            }
            Console.ReadLine();


            Console.ReadKey();
        }


        static bool test()
        {
            Func<int, int, int, bool> addandcompare = (x, y, z) =>
            {
                int a = x + y + z;
                Console.WriteLine(a);
                return a > 100;
            };
            return false;
        }    

    }
}

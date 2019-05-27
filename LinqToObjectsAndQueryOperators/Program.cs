using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();

            um.StudentAndUniversityNameCollection();

            /*

            int[] someInts = { 30, 12, 4, 3, 12 };

            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }
            */

            /*
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);

                um.AllStudentsFromUniversityId(inputAsInt);
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong value");
            }
            */

            Console.ReadKey();
        }
    }


}

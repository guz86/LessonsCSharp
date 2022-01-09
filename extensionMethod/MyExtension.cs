using System;
using ExtensionStudent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class MyExtension
    {
        // методы расширения должны быть статическими
        // и находиться в статическом классе
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }

        public static string GetFullName(this Student student)
        {
            return student.FirstName + student.LastName;
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMuchGrandmother;
            int hour = 60;
            int minutes = 10;
            int hoursInHospital;
            int minutesInHospital;

            Console.WriteLine("Количество старушек перед вами");
            howMuchGrandmother = Convert.ToInt32(Console.ReadLine());
             
            minutes = howMuchGrandmother * minutes;
            hoursInHospital = minutes / hour;
            minutesInHospital = minutes - hour * hoursInHospital;

            Console.WriteLine("Вы должны отстоять в очереди: {0} часа, {1} минут", hoursInHospital, minutesInHospital); 

        }
    }
}

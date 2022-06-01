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
            int amountGrandmothers;
            int minutesInHour = 60;
            int minutesForOneHuman = 10;
            int hoursWatching;
            int minutesWatching;

            Console.WriteLine("Количество старушек перед вами");
            amountGrandmothers = Convert.ToInt32(Console.ReadLine());
             
            minutesForOneHuman = amountGrandmothers * minutesForOneHuman;
            hoursWatching = minutesForOneHuman / minutesInHour;
            minutesWatching = minutesForOneHuman - minutesInHour * hoursWatching;

            Console.WriteLine("Вы должны отстоять в очереди: {0} часа, {1} минут", hoursWatching, minutesWatching); 

        }
    }
}

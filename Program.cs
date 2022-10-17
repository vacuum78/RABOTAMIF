using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧЕРНИКОВ_ДЕНИС_2_РАБОТА
{ using static Console;
    class HelloUser
    {
        static void Main(string[] args)
        {
            string name;
            WriteLine("Введите ваше имя и фамилию: ");
            name = ReadLine();
            WriteLine("Индивидуальный гороскоп для пользователя" + name + "!");
            WriteLine("Кем вы были в прошлой жизни:");
            ReadLine();
            WriteLine("Ваш знак зодиака");
            name = ReadLine();
            WriteLine("Ваш знак зодиака - " + name + ", поэтому вы тонко чувствующая натура");
        }
    }
}

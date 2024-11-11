using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecoratorSms : Decorator
    {
        public override void Send(string messaqge, string name)
        {
            if (notifier.Notifiers.Contains(name))
            {
                Console.WriteLine($"Отправка на номер телефона: <<{messaqge}>> для {name}");
            }
            else
            {
                Console.WriteLine($"Нет администратора {name}");
            }
        }
    }
}

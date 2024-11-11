using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Notifier : INotifer
    {
        public List<string> Notifiers { get; }
        public Notifier(List<string> notifiers)
        {
            Notifiers = notifiers;
        }
        public void Send(string message, string name = null)
        {
            if(name == null)
            {
                foreach (var notifier in Notifiers)
                {
                    Console.WriteLine($"Внимание, {notifier}@gmail.com, случилось: {message}");
                }
            }
            else
            {
                Console.WriteLine($"Внимание, {name}@gmail.com, случилось: {message}");
            }
        }
    }
}

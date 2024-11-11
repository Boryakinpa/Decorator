using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Decorator : INotifer
    {
        protected Notifier notifier;
        public void SetComponent(Notifier notifier)
        {
            this.notifier = notifier;
        }

        public virtual void Send(string message, string name)
        {
            if (notifier != null)
            {
                notifier.Send(message, name);
            }
        }
    }
}

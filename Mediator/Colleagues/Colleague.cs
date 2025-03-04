using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public abstract class Colleague
    {
        protected MediatoR mediator;
        public Colleague(MediatoR mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}

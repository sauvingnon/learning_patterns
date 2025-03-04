using Mediator.Colleagues;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    public abstract class MediatoR
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}

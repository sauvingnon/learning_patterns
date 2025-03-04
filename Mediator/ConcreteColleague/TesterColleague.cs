using Mediator.Colleagues;
using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleague
{
    public class TesterColleague : Colleague
    {
        public TesterColleague(MediatoR mediator)
            : base(mediator)
            { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение тестировщику: {message}");
        }
    }
}

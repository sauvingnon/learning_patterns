using Mediator.Colleagues;
using Mediator.ConcreteColleague;
using Mediator.ConcreteMediator;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator manager = new ManagerMediator();
            Colleague programmer = new ProgrammerColleague(manager);
            Colleague customer = new CustomerColleague(manager);
            Colleague tester = new TesterColleague(manager);

            manager.Programmer = programmer;
            manager.Customer = customer;
            manager.Tester = tester;

            customer.Send("Появился заказ, надо сделать программу.");
            programmer.Send("Программа написана, надо протестировать.");
            tester.Send("Программа протестирована и готова к продаже.");
        }
    }
}

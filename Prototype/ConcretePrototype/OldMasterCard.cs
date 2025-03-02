using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcretePrototype
{
    /// <summary>
    /// Конкретная реализация прототипа.
    /// Реализует метод Clone()
    /// </summary>
    public class OldMasterCard : Card
    {
        public override string? Name => "Старый мудрец";
        public override int Points => 2;

        public override Card Clone()
        {
            return new OldMasterCard();
        }
    }
}

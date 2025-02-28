using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entity
{
    /// <summary>
    /// Объект, который должен быть создан.
    /// </summary>
    public class Phone
    {
        private string data;
        public Phone() => data = "";
        public string AboutPhone() => data;
        public void AppendData(string additionData) => data += additionData;

    }
}

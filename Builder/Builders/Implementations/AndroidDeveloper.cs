using Builder.Builders.Interfaces;
using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders.Implementations
{
    /// <summary>
    /// Конкретная реализация Builder'а.
    /// Создает объект Phone и определяет интерфейс для доступа к нему
    /// </summary>
    public class AndroidDeveloper : IDeveloper
    {
        private Phone phone;
        public AndroidDeveloper() => phone = new Phone();
        public void CreateBox() => phone.AppendData("Произведен корпус Samsung\n");

        public void CreateDisplay() => phone.AppendData("Произведен дисплей Samsung\n");

        public void SystemInstall() => phone.AppendData("Установлена система Android\n");

        public Phone GetPhone() => phone;

    }
}

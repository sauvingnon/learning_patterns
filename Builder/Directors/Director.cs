using Builder.Builders.Interfaces;
using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    /// <summary>
    /// Распорядитель - создает объект, используя объекты Builder
    /// </summary>
    public class Director
    {
        private IDeveloper developer;

        public Director(IDeveloper developer) => this.developer = developer;

        public void SetDeveloper(IDeveloper developer) => this.developer = developer;

        /// <summary>
        /// Создание только корпуса телефона
        /// </summary>
        public Phone MountOnlyPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            return developer.GetPhone();
        }
        /// <summary>
        /// Создание полноценного телефона
        /// </summary>
        /// <returns></returns>
        public Phone MountFullPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            developer.SystemInstall();
            return developer.GetPhone();
        }
    }
}

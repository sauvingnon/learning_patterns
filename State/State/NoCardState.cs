namespace State
{
    /// <summary>
    /// Состояние 1: Нет карты
    /// </summary>
    public class NoCardState : IATMState
    {
        private ATMContext _atm;

        public NoCardState(ATMContext atm) => _atm = atm;

        public void InsertCard()
        {
            Console.WriteLine("Карта вставлена.");
            _atm.SetState(_atm.HasCardState);
        }

        public void EjectCard() => Console.WriteLine("Нет карты для извлечения.");
        public void EnterPin(int pin) => Console.WriteLine("Сначала вставьте карту.");
        public void WithdrawCash(int amount) => Console.WriteLine("Сначала вставьте карту.");
    }

}

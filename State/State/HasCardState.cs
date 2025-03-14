namespace State
{
    /// <summary>
    /// Состояние 2: Карта вставлена
    /// </summary>
    public class HasCardState : IATMState
    {
        private ATMContext _atm;

        public HasCardState(ATMContext atm) => _atm = atm;

        public void InsertCard() => Console.WriteLine("Карта уже вставлена.");

        public void EjectCard()
        {
            Console.WriteLine("Карта извлечена.");
            _atm.SetState(_atm.NoCardState);
        }

        public void EnterPin(int pin)
        {
            Console.WriteLine("PIN введен успешно.");
            _atm.SetState(_atm.DispensingCashState);
        }

        public void WithdrawCash(int amount) => Console.WriteLine("Введите PIN сначала.");
    }

}

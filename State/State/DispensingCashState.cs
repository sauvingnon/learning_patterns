namespace State
{
    /// <summary>
    /// Состояние 3: Выдача наличных
    /// </summary>
    public class DispensingCashState : IATMState
    {
        private ATMContext _atm;

        public DispensingCashState(ATMContext atm) => _atm = atm;

        public void InsertCard() => Console.WriteLine("Пожалуйста, подождите, операция выполняется.");

        public void EjectCard() => Console.WriteLine("Операция выполняется, невозможно извлечь карту.");

        public void EnterPin(int pin) => Console.WriteLine("PIN уже введен.");

        public void WithdrawCash(int amount)
        {
            Console.WriteLine($"Выдано {amount} рублей.");
            _atm.SetState(_atm.NoCardState); // Возвращаемся в начальное состояние
        }
    }

}

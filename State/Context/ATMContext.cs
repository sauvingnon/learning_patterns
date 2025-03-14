namespace State
{
    /// <summary>
    /// Этот класс управляет состояниями и переключает их
    /// </summary>
    public class ATMContext
    {
        public IATMState NoCardState { get; private set; }
        public IATMState HasCardState { get; private set; }
        public IATMState DispensingCashState { get; private set; }

        private IATMState _currentState;

        public ATMContext()
        {
            NoCardState = new NoCardState(this);
            HasCardState = new HasCardState(this);
            DispensingCashState = new DispensingCashState(this);

            _currentState = NoCardState; // Начальное состояние
        }

        public void SetState(IATMState newState) => _currentState = newState;

        public void InsertCard() => _currentState.InsertCard();
        public void EjectCard() => _currentState.EjectCard();
        public void EnterPin(int pin) => _currentState.EnterPin(pin);
        public void WithdrawCash(int amount) => _currentState.WithdrawCash(amount);
    }

}

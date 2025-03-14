namespace State
{
    /// <summary>
    /// Каждое состояние реализует этот интерфейс
    /// </summary>
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin(int pin);
        void WithdrawCash(int amount);
    }
}

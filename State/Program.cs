namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMContext atm = new ATMContext();

            atm.InsertCard();    // Карта вставлена.
            atm.EnterPin(1234);  // PIN введен успешно.
            atm.WithdrawCash(5000); // Выдано 5000 рублей.

            atm.InsertCard();    // Карта вставлена.
            atm.EjectCard();     // Карта извлечена.
        }
    }
}

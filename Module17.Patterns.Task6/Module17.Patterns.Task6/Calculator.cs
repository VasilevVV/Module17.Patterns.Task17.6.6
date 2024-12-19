namespace Module17.Patterns.Task6;

/// <summary>
/// Калькулятор
/// </summary>
public static class Calculator
{
    /// <summary>
    /// Метод для расчета процентной ставки
    /// </summary>
    /// <param name="account">Аккаунт</param>
    public static void CalculateInterest(Account account)
    {
        if (account.Type == "Обычный")
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
        else if (account.Type == "Зарплатный")
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
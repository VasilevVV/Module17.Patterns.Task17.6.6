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
    public static void CalculateInterest(IBankAccount account)
    {
        account.CalculateInterest();        
    }
}
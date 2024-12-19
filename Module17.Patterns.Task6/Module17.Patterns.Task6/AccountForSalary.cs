namespace Module17.Patterns.Task6;

/// <summary>
/// Зарплатный аккаунт
/// </summary>
public class AccountForSalary : AccountNormal
{    
    /// <summary>
    /// расчет процентной ставки
    /// </summary>
    public override void CalculateInterest()
    {
        this.Interest = Balance * 0.5;
    }
}

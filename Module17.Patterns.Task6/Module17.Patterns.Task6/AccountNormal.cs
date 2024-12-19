namespace Module17.Patterns.Task6;

/// <summary>
/// обычный аккаунта
/// </summary>
public class AccountNormal : IBankAccount
{
    /// <summary>
    /// баланс учетной записи
    /// </summary>
    public double Balance { get; set; }

    /// <summary>
    /// процентная ставка
    /// </summary>
    public double Interest { get; set; }

    /// <summary>
    /// расчет процентной ставки
    /// </summary>
    public virtual void CalculateInterest()
    {
        this.Interest = this.Balance * 0.4;
        if (this.Balance < 1000)
            this.Interest -= this.Balance * 0.2;
        if (this.Balance >= 1000)
            this.Interest -= this.Balance * 0.4;
    }
}

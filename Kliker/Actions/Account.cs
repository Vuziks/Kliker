namespace Kliker.Actions;

public class Account : ChangeableAction
{
    private decimal sum;
    private decimal income;
    private decimal multiplier;

    public Account()
    {
        Sum = 0;
        Income = 0;
        Multiplier = 1;
    }

    public decimal Sum { get => sum; set { sum = value; NotifyStateChanged(); } }
    public decimal Income { get => income; set { income = value; NotifyStateChanged(); } }
    public decimal Multiplier { get => multiplier; set { multiplier = value; NotifyStateChanged(); } }

    public void Increment() => Sum += 1 * Multiplier;

    public static string Pln(decimal value) => value.ToString("C2");

    public void Primaries() => Multiplier += 10m;

    public void Reevaluate() => Sum += Income * Multiplier;
}
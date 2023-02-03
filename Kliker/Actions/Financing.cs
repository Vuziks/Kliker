namespace Kliker.Actions;

public class Financing : ChangeableAction
{
    public List<FinancingAction> Actions { get; set; }

    private readonly Account account;

    public Financing(Account account)
    {
        this.account = account;

        Actions = new List<FinancingAction>
        {
            new FinancingAction("poleć babci", 15, 0.2m),
            new FinancingAction("wydrukuj ulotki", 30, 0.8m),
            new FinancingAction("sprzedaj respirator", 100, 1.5m),
        };
    }

    public void Finance(FinancingAction action)
    {
        account.Sum -= action.Cost;
        account.Income += action.Income;
        action.Cost *= 1.2m;
        NotifyStateChanged();
    }

    public bool CanFinance(FinancingAction action)
    {
        return action.Cost >= account.Sum;
    }
}

public class FinancingAction
{
    public FinancingAction(string actionName, decimal cost, decimal income)
    {
        ActionName = actionName;
        Cost = cost;
        Income = income;
    }

    public string ActionName { get; set; }
    public decimal Cost { get; set; }
    public decimal Income { get; set; }
}
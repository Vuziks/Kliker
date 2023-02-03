namespace Kliker.Actions
{
    public class ChangeableAction
    {
        public event Action OnChange = default!;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}

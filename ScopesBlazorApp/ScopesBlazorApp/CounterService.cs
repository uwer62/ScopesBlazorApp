namespace ScopesBlazorApp;

public class CounterService
{
    public int IncrementCounter() => this.CurrentCount++;
    public int CurrentCount { get; private set; }
}

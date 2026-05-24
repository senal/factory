namespace documentRules.Rules.Defaults
{
    [AssetRule]
    [DefaultRule]
    public class TaxInvoice : IRule
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Tax Invoice");
            await Task.CompletedTask;
        }
    }
}
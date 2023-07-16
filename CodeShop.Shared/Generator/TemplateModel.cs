namespace CodeShop.Shared.Generator;

public class TemplateModel
{
    public Database Database { get; set; }

    public Table SelectedTable { get; set; }

    public IDictionary<string, string> CustomValues { get; set; } = new Dictionary<string, string>();
}
using CodeShop.Shared.Extensions;
using CodeShop.Shared.Generator;
using Fluid;

namespace CodeShop.Generator;

public class Client
{
    private static readonly FluidParser parser;
    private static readonly TemplateOptions templateOptions;

    static Client()
    {
        parser = new FluidParser();
        templateOptions = new TemplateOptions();
        templateOptions.MemberAccessStrategy.Register<Database>();
        templateOptions.MemberAccessStrategy.Register<Table>();
        templateOptions.MemberAccessStrategy.Register<Column>();
        templateOptions.Filters.AddCustomFilters();
    }

    public event EventHandler OnComplete;

    public string Parse(TemplateModel model, string inputString)
    {
        if (parser.TryParse(inputString, out var template, out string error))
        {
            var context = new TemplateContext(model, templateOptions);
            string result = template.Render(context);
            OnComplete?.Invoke(this, new EventArgs());
            return result;
        }
        else
        {
            throw new ApplicationException("Unable to parse the template. Please check and fix any errors.");
        }
    }
}
using CodeShop.Shared.Extensions;
using CodeShop.Shared.Generator;
using Fluid;

namespace CodeShop.Generator;

public static class TemplateParser
{
    private static readonly FluidParser parser;
    private static readonly TemplateOptions templateOptions;

    static TemplateParser()
    {
        parser = new FluidParser();
        templateOptions = new TemplateOptions();
        templateOptions.MemberAccessStrategy.Register<Database>();
        templateOptions.MemberAccessStrategy.Register<Table>();
        templateOptions.MemberAccessStrategy.Register<Column>();
        templateOptions.MemberAccessStrategy.Register<Key>();
        templateOptions.Filters.AddCustomFilters();
    }

    public static string Parse(TemplateModel model, string inputString)
    {
        if (parser.TryParse(inputString, out var template, out string error))
        {
            var context = new TemplateContext(model, templateOptions);
            return template.Render(context);
        }
        else
        {
            throw new ApplicationException($"Unable to parse the template. Please check and fix any errors. {error}.");
        }
    }
}
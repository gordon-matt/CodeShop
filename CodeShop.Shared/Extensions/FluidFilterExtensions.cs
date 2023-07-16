using System.CodeDom;
using System.Threading.Tasks;
using CodeShop.Extensions;
using Fluid;
using Fluid.Values;
using Humanizer;
using Pluralize.NET;

namespace CodeShop.Shared.Extensions;

public static class FluidFilterExtensions
{
    private static readonly Pluralizer pluralizer;

    static FluidFilterExtensions()
    {
        pluralizer = new Pluralizer();
    }

    public static void AddCustomFilters(this FilterCollection filters)
    {
        filters.AddFilter("MAP_TYPE", MapType);
        filters.AddFilter("REPLACE", Replace);

        filters.AddFilter("UPPER", Upper);
        filters.AddFilter("LOWER", Lower);
        filters.AddFilter("CAMEL", Camelize);
        filters.AddFilter("PASCAL", Pascalize);
        filters.AddFilter("UNDERSCORE", Underscore);
        filters.AddFilter("HUMAN", Titleize);
        filters.AddFilter("HYPHEN", Kebaberize);
        filters.AddFilter("HYPHEN_LOWER", LowerKebaberize);
        filters.AddFilter("HYPHEN_UPPER", UpperKebaberize);
        filters.AddFilter("PLURALIZE", Pluralize);
        filters.AddFilter("SINGULARIZE", Singularize);
    }

    public static ValueTask<FluidValue> MapType(FluidValue input, FilterArguments arguments, TemplateContext context)
    {
        var dbType = (DbType)int.Parse(input.ToStringValue());
        var systemType = DataTypeConvertor.GetSystemType(dbType);

        using var codeProvider = new CSharpCodeProvider();
        var typeRef = new CodeTypeReference(systemType);
        string typeName = codeProvider.GetTypeOutput(typeRef);

        return new StringValue(typeName);
    }

    public static ValueTask<FluidValue> Replace(FluidValue input, FilterArguments arguments, TemplateContext context)
    {
        string inputValue = input.ToStringValue();
        string oldValue = arguments.At(0).ToStringValue();
        string newValue = arguments.At(1).ToStringValue();

        return new StringValue(inputValue.Replace(oldValue, newValue));
    }

    public static ValueTask<FluidValue> Upper(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().ToUpper());

    public static ValueTask<FluidValue> Lower(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().ToLower());

    public static ValueTask<FluidValue> Camelize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().Camelize());

    public static ValueTask<FluidValue> Kebaberize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().KebaberizeNoCaseChange());

    public static ValueTask<FluidValue> LowerKebaberize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().Kebaberize());

    public static ValueTask<FluidValue> Pascalize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().Pascalize());

    public static ValueTask<FluidValue> Titleize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().Titleize());

    public static ValueTask<FluidValue> Underscore(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().UnderscoreNoCaseChange());

    public static ValueTask<FluidValue> UpperKebaberize(FluidValue input, FilterArguments arguments, TemplateContext context) =>
        new StringValue(input.ToStringValue().Kebaberize().ToUpper());

    public static ValueTask<FluidValue> Pluralize(FluidValue input, FilterArguments arguments, TemplateContext context)
        => new StringValue(pluralizer.Pluralize(input.ToStringValue()));

    public static ValueTask<FluidValue> Singularize(FluidValue input, FilterArguments arguments, TemplateContext context)
        => new StringValue(pluralizer.Singularize(input.ToStringValue()));
}
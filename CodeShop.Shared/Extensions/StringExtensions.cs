using CodeShop.Generator;

namespace CodeShop;

public static class StringExtensions
{
    public static string DelimeterWrap(this string source)
    {
        return $"{Context.StartDelimeter}{source}{Context.EndingDelimiter}";
    }
}
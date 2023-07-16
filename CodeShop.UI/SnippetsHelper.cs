namespace CodeShop.UI;

/// <summary>
/// Summary description for SnippetsHelper.
/// </summary>
public static class SnippetsHelper
{
    public static IDictionary<string, string> Snippets { get; } = new Dictionary<string, string>();

    static SnippetsHelper()
    {
        Snippets.Add("Database Name", "{{ Database.Name }}");
        Snippets.Add("Tables", "{% for table in Database.Tables %}[Your Code Here]{% endfor %}");

        Snippets.Add("Table Schema", "{{ table.Schema }}");
        Snippets.Add("Table Name", "{{ table.Name | PASCAL }}");
        Snippets.Add("Table Name (REPLACE)", @"{{ table.Name | REPLACE: ""OldValue"",""NewValue"" }}");
        Snippets.Add("Columns", "{% for column in table.Columns %}[Your Code Here]{% endfor %}");

        Snippets.Add("[Selected] Table Schema", "{{ SelectedTable.Schema }}");
        Snippets.Add("[Selected] Table Name", "{{ SelectedTable.Name | PASCAL }}");
        Snippets.Add("[Selected] Table Name (REPLACE)", @"{{ SelectedTable.Name | REPLACE: ""OldValue"",""NewValue"" }}");
        Snippets.Add("[Selected] Table Columns", "{% for column in SelectedTable.Columns %}[Your Code Here]{% endfor %}");

        Snippets.Add("Column Name", "{{ column.Name | SINGULARIZE | PASCAL }}");
        Snippets.Add("Column Type", "{{ column.NativeType }}");
        Snippets.Add("Mapped Column Type", "{{ column.DbType | MAP_TYPE }}");
        Snippets.Add("Column Length", "{{ column.Length }}");
        Snippets.Add("Column Default", "{{ column.Default }}");
        Snippets.Add("Is Column Nullable?", "{% if column.Nullable %}[Your Code Here]{% endif %}");
        Snippets.Add("Is Column Primary Key?", "{% if column.IsPrimaryKey %}[Your Code Here]{% endif %}");

        Snippets.Add("If Column Name…", @"{% if column.Name == ""Foo"" %}[Your Code Here]{% endif %}");
        Snippets.Add("Unless Column Name…", @"{% unless column.Name == ""Foo"" %}[Your Code Here]{% endunless %}");

        Snippets.Add("If Column Type…", @"{% if column.NativeType == ""Foo"" %}[Your Code Here]{% endif %}");
        Snippets.Add("Unless Column Type…", @"{% unless column.NativeType == ""Foo"" %}[Your Code Here]{% endunless %}");

        Snippets.Add("Is Last Column?",
@"{% for column in table.Columns %}
    {{ forloop.index }}. {{ column.Name }}{% unless forloop.last %},{% endunless %}
{% endfor %}");

        Snippets.Add("Custom Value", @"{{ CustomValues[""MyKey""] }}");
    }
}
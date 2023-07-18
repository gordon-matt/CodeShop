namespace CodeShop.UI;

/// <summary>
/// Summary description for SnippetsHelper.
/// </summary>
public static class SnippetsHelper
{
    public static IDictionary<string, string> Snippets { get; } = new Dictionary<string, string>
    {
        // Database
        { "Database Name", "{{ Database.Name }}" },
        { "Tables", "{% for table in Database.Tables %}[Your Code Here]{% endfor %}" },

        // Table
        { "Table Schema", "{{ table.Schema }}" },
        { "Table Name", "{{ table.Name | PASCAL }}" },
        { "Table Name (REPLACE)", @"{{ table.Name | REPLACE: ""OldValue"",""NewValue"" }}" },
        { "Columns", "{% for column in table.Columns %}[Your Code Here]{% endfor %}" },

        // Selected Table
        { "[Selected] Table Schema", "{{ SelectedTable.Schema }}" },
        { "[Selected] Table Name", "{{ SelectedTable.Name | PASCAL }}" },
        { "[Selected] Table Name (REPLACE)", @"{{ SelectedTable.Name | REPLACE: ""OldValue"",""NewValue"" }}" },
        { "[Selected] Table Columns", "{% for column in SelectedTable.Columns %}[Your Code Here]{% endfor %}" },

        // Column
        { "Column Name", "{{ column.Name | SINGULARIZE | PASCAL }}" },
        { "Column Type", "{{ column.NativeType }}" },
        { "Mapped Column Type", "{{ column.DbType | MAP_TYPE }}" },
        { "Column Length", "{{ column.Length }}" },
        { "Column Default", "{{ column.Default }}" },
        { "Is Column Nullable?", "{% if column.Nullable %}[Your Code Here]{% endif %}" },
        { "Is Column Primary Key?", "{% if column.IsPrimaryKey %}[Your Code Here]{% endif %}" },

        { "If Column Name…", @"{% if column.Name == ""Foo"" %}[Your Code Here]{% endif %}" },
        { "Unless Column Name…", @"{% unless column.Name == ""Foo"" %}[Your Code Here]{% endunless %}" },

        { "If Column Type…", @"{% if column.NativeType == ""Foo"" %}[Your Code Here]{% endif %}" },
        { "Unless Column Type…", @"{% unless column.NativeType == ""Foo"" %}[Your Code Here]{% endunless %}" },

        {
            "Is Last Column?",
@"{% for column in table.Columns %}
    {{ forloop.index }}. {{ column.Name }}{% unless forloop.last %},{% endunless %}
{% endfor %}"
        },

        // Other
        { "Custom Value", @"{{ CustomValues[""MyKey""] }}" }
    };
}
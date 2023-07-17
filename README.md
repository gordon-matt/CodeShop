<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Logo.png" alt="Logo" />

Code Shop
==============

Code Shop is a database centric template based code generator for any text(ascii) programming language like C, PHP, C#, Visual Basic, Java, Perl, Python… Supported databases are SQL Server, MySQL, PostgreSQL and Oracle.

## Screenshots
#### Simple Template:
<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Screenshots/Simple.PNG" alt="Simple Template" />

#### Results:
<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Screenshots/Simple_Results.PNG" alt="Simple Template Results" />

Documentation
# Intro

Code Shop makes use of an open-source .NET template engine called [Fluid](https://github.com/sebastienros/fluid), which is based on the [Liquid template language](https://shopify.github.io/liquid/).

As such, you can use all the filters (functions), operators, control flow tags and so forth that are specified in the documentation linked above.

All that you as a user needs to know then is what the model looks like, so that you can create code for your selected database table(s).

When you click, “Generate”, data representing your selected table and its parent database is passed to the templating engine which is structured as follows:

<table><tr><th colspan="1" rowspan="14" valign="top"><b>Database</b></th><th colspan="1" valign="top">Name</th><th colspan="1" valign="top"></th><th colspan="1" valign="top"></th></tr>
<tr><td colspan="1" rowspan="12" valign="top">Tables</td><td colspan="1" valign="top">Schema</td><td colspan="1" valign="top"></td></tr>
<tr><td colspan="1" valign="top">Name</td><td colspan="1" valign="top"></td></tr>
<tr><td colspan="1" rowspan="7" valign="top">Columns</td><td colspan="1" valign="top">Name</td></tr>
<tr><td colspan="1" valign="top">NativeType</td></tr>
<tr><td colspan="1" valign="top">DbType</td></tr>
<tr><td colspan="1" valign="top">IsPrimaryKey</td></tr>
<tr><td colspan="1" valign="top">Length</td></tr>
<tr><td colspan="1" valign="top">Nullable</td></tr>
<tr><td colspan="1" valign="top">Default</td></tr>
<tr><td colspan="1" rowspan="3" valign="top">Keys</td><td colspan="1" valign="top">Name</td></tr>
<tr><td colspan="1" valign="top">ColumnName</td></tr>
<tr><td colspan="1" valign="top">IsPrimary</td></tr>
<tr><td colspan="1" valign="top">Views</td><td colspan="1" valign="top">[Same as “Tables” above]</td><td colspan="1" valign="top"></td></tr>
<tr><td colspan="1" valign="top"><b>SelectedTable</b></td><td colspan="1" valign="top">[Single instance of “Table” model already defined above] – Represents the currently selected table in the TreeView.</td><td colspan="1" valign="top"></td><td colspan="1" valign="top"></td></tr>
<tr><td colspan="1" valign="top"><b>CustomValues</b></td><td colspan="1" valign="top">A collection of key/value pairs you can define via the UI to be used in your template </td><td colspan="1" valign="top"></td><td colspan="1" valign="top"></td></tr>
</table>

# Example Snippets
## Database
- Output the database name: `{{ Database.Name }}`
- Iterate over all tables in the selected database:

```
{% for table in Database.Tables %}
    [Your Code Here]
{% endfor %}
```

## Table
- Output the table schema: `{{ table.Schema }} or {{ SelectedTable.Schema }}`
- Output the table name: `{{ table.Name }} or {{ SelectedTable.Name }}`
- Iterate over all columns in the selected table:

```
{% for column in table.Columns %}
[Your Code Here]
{% endfor %}
```

Or…

```
{% for column in SelectedTable.Columns %}
[Your Code Here]
{% endfor %}
```

## Columns
- Output the column name: `{{ column.Name }}`
- Output the column type: `{{ column.NativeType }}`
- Output the mapped column type: `{{ column.DbType | MAP_TYPE }}`

This will output the selected programming language's data type mapped from the source database type. Configurable via the UI.

- Output the column length: `{{ column.Length }}`
- Output the column default: `{{ column.Default }}`
- Check if the column is nullable: `{% if column.Nullable %}[Your Code Here]{% endif %}`
- Check if the column is a primary key: `{% if column.IsPrimaryKey %}[Your Code Here]{% endif %}`

There are more snippets available on the Snippets flyout menu on the UI.
## Custom Values
- Your own values can be accessed as follows:

`{{ CustomValues["MyKey"] }}`

## Additional Filters
The templating language already has built-in functions (known as filters). A simple example of this is downcase, which is used as follows:

`{{ "APPLE" | downcase }}`

The output of which would be apple. More built-in filters can be found at:

[https://shopify.github.io/liquid/basics/introduction/#filters]()
# Example Template
## Example 1:

```
using {{ CustomValues["Namespace"] }}.Data.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace {{ CustomValues["Namespace"] }}.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
{% for table in Database.Tables %}
    public DbSet<{{ table.Name | PASCAL }}> {{ table.Name | PASCAL }} { get; set; }
{% endfor %}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
{% for table in Database.Tables %}
        builder.ApplyConfiguration(new {{ table.Name | PASCAL }}Map());{% endfor %}
    }
}

```

## Example 2:

```
{% assign entityName = SelectedTable.Name | REPLACE: "ABC","_" | PASCAL | SINGULARIZE %}using System;
using Extenso.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace {{ CustomValues["Namespace"] }}.Data.Domain;

public class {{ entityName }} : IEntity
{ {% for column in SelectedTable.Columns %}
    public {{ column.DbType | MAP_TYPE }} {{ column.Name | PASCAL }} { get; set; }
{% endfor %}
    public object[] KeyValues => new object[] { {% for column in SelectedTable.Columns %}{% if column.IsPrimaryKey %}{{ column.Name }}{% endif %}{% endfor %} };
}

public class {{ entityName }}Map : IEntityTypeConfiguration<{{ entityName }}>
{
    public void Configure(EntityTypeBuilder<{{ entityName }}> builder)
    {
        builder.ToTable("{{ SelectedTable.Name }}", "{{ SelectedTable.Schema }}");
        {% for column in SelectedTable.Columns %}
        {% if column.IsPrimaryKey %}builder.HasKey(m => m.{{ column.Name }});{% endif %}{% unless column.IsPrimaryKey %}builder.Property(m => m.{{ column.Name }}).HasColumnType("{{ column.NativeType }}"){% if column.Nullable %}.IsRequired(){% endif %}{% endunless %}{% if column.Length != null %}.HasMaxLength({{ column.Length }}){% endif %}{% endfor %}
    }
}
```

## Additional Notes:
- If you name your templates using the {{ SelectedTable.Name }} expression, it will automatically generate the correct file name for you as well. Examples:

**TODO: In Progress**

### Future Work:

It would be good to have the following work done in future:

- Separate the views from the tables.. example: {VIEW.COLUMNS…}, {VIEW.NAME…}, etc.
- Support for foreign key info, so that we can generate things like EF Navigation Properties

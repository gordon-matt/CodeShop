[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)

<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Logo.jpg" alt="Logo" />

Code Shop
==============

Code Shop is a database centric template based code generator for any text(ascii) programming language like C, PHP, C#, Visual Basic, Java, Perl, Python… Supported databases are SQL Server, MySQL, PostgreSQL and Oracle.

## Screenshots
#### Example Template:
<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Screenshots/Example.PNG" alt="Example Template" />

#### Results:
<img src="https://github.com/gordon-matt/CodeShop/blob/main/Misc/Screenshots/Example_Results.PNG" alt="Example Template Results" />

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

The output of which would be `apple`. More built-in filters can be found at:

https://shopify.github.io/liquid/basics/introduction/#filters

In addition to these built-in filters, CodeShop provides the following ones:

- CAMEL: Converts the string to camel case
- PASCAL: Converts the string to pascal case
- UNDERSCORE: Replaces each whitespace character with an underscore
- HUMAN: Humanizes the string with title casing.
- HYPHEN: Replaces each whitespace character with a hyphen
- HYPHEN_LOWER: Replaces each whitespace character with a hyphen and converts every character to lower case
- HYPHEN_UPPER: Replaces each whitespace character with a hyphen and converts every character to upper case
- PLURALIZE: Pluralizes the string.
- SINGULARIZE: Singularizes the string.
- UPPER: Converts the string to upper case. Same as `upcase`
- LOWER: Converts the string to lower case. Same as `downcase`
- REPLACE: Replaces a substring with another string. Example: REPLACE: "MyCompany_","". Thus, "MyCompany_Languages" becomes "Languages".
- MAP_TYPE: Only works with the `DbType` property on a column object. Example: `{{ column.DbType | MAP_TYPE }}`. It will output the mapped data type.. which by default is C#, but can be changed to whatever language you want in the settings.

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
        {% if column.IsPrimaryKey %}builder.HasKey(m => m.{{ column.Name }});{% endif %}{% unless column.IsPrimaryKey %}builder.Property(m => m.{{ column.Name }}).HasColumnType("{{ column.NativeType }}"){% if column.Nullable %}.IsRequired(){% endif %}{% endunless %}{% if column.Length != null %}.HasMaxLength({{ column.Length }}){% endif %};{% endfor %}
    }
}
```

## Additional Notes:
- If you name your templates using the {{ SelectedTable.Name }} expression, it will automatically generate the correct file name for you as well. Note that you can still use liquid template filters as well, but because the vertical bar character (`|`) is not allowed in file paths, then you can replace `|` with `^` in the file names and they will be converted back to `|` for processing. Examples:

```
{{ SelectedTable.Name ^ SINGULARIZE ^ PASCAL }}.cs
{{ SelectedTable.Name ^ SINGULARIZE ^ PASCAL }}Controller.cs
{{ SelectedTable.Name ^ PLURALIZE ^ CAMEL }}.js
```

If your selected table is named, `Person`, the above example templates would result in the following files being generated:

```
Person.cs
PersonController.cs
people.js
```

### Future Work:

It would be good to have the following work done in future:

- Separate the views from the tables.. example: {VIEW.COLUMNS…}, {VIEW.NAME…}, etc.
- Support for foreign key info, so that we can generate things like EF Navigation Properties

- Better UI for db connections
- Split each db connection type into separate projects
- Show collection of file templates on UI
- Import templates
- Import language
- Save configuration to a folder (1 main file for connection settings, custom values, etc.. plus separate files for templates, languages etc)
- Allow rich text boxes to have different language markup to the data mappings language. Example: data mapping can be C#, but we're templating out a Razor file
  (so want to have HTML as the language used in the rich text box..)
- Custom snippets?
- Use ribbon instead of toolstrip?

## Credits

The original idea for this project came from this tool: https://github.com/VientoDigital/codegenerator.
I worked a lot on improving that to what it is today, but eventually decided to go ahead and rewrite it to
use the liquid templating engine instead of the custom one that was used in that project.

## Donate
If you find this project helpful, consider buying me a cup of coffee.

[![PayPal](https://img.shields.io/badge/PayPal-003087?logo=paypal&logoColor=fff)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)
[![Bitcoin](https://img.shields.io/badge/Bitcoin-FF9900?logo=bitcoin&logoColor=white)](bitcoin:1EeDfbcqoEaz6bbcWsymwPbYv4uyEaZ3Lp)
[![Ethereum](https://img.shields.io/badge/Ethereum-3C3C3D?logo=ethereum&logoColor=white)](ethereum:0x277552efd6ea9ca9052a249e781abf1719ea9414)
[![Litecoin](https://img.shields.io/badge/Litecoin-A6A9AA?logo=litecoin&logoColor=white)](litecoin:LRUP8hukWGXRrcPK6Tm7iUp9vPvnNNt3uz)

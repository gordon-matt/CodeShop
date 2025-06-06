﻿namespace CodeShop.UI;

public partial class SettingsForm : KryptonForm
{
    public SettingsForm()
    {
        InitializeComponent();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        RefreshLanguages();
    }

    private string SelectedLanguage => (string)cmbLanguage.SelectedItem;

    private void RefreshLanguages()
    {
        cmbLanguage.DataSource = null;
        var languages = new List<string> { ".NET", "C#", "VB" };
        if (!ConfigFile.Instance.Languages.IsNullOrEmpty())
        {
            var additionalLanguages = ConfigFile.Instance.Languages
                .Where(x => !x.Name.In(languages))
                .Select(x => x.Name)
                .OrderBy(x => x);

            languages.AddRange(additionalLanguages);
        }
        cmbLanguage.DataSource = languages;
        int index = cmbLanguage.Items.IndexOf(ConfigFile.Instance.SelectedLanguage.Name);
        cmbLanguage.SelectedIndex = index;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var addLanguageForm = new AddNewLanguageForm();
        if (addLanguageForm.ShowDialog() == DialogResult.OK)
        {
            var languageConfig = new Language
            {
                Name = addLanguageForm.LanguageName,
                Mappings = new Dictionary<string, string>
                {
                    { "bigint", string.Empty },
                    { "bit", string.Empty },
                    { "char", string.Empty },
                    { "date", string.Empty },
                    { "datetime", string.Empty },
                    { "decimal", string.Empty },
                    { "double", string.Empty },
                    { "float", string.Empty },
                    { "image", string.Empty },
                    { "int", string.Empty },
                    { "integer", string.Empty },
                    { "nchar", string.Empty },
                    { "ntext", string.Empty },
                    { "number", string.Empty },
                    { "numeric", string.Empty },
                    { "nvarchar", string.Empty },
                    { "real", string.Empty },
                    { "smallint", string.Empty },
                    { "text", string.Empty },
                    { "time", string.Empty },
                    { "timestamp", string.Empty },
                    { "tinyint", string.Empty },
                    { "uniqueidentifier", string.Empty },
                    { "varchar", string.Empty },
                    { "varchar2", string.Empty },
                }
            };
            ConfigFile.Instance.Languages.Add(languageConfig);
            ConfigFile.Instance.SelectedLanguageName = languageConfig.Name;
            RefreshLanguages();
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (SelectedLanguage.In(".NET", "C#", "VB"))
        {
            MessageBox.Show("You cannot delete that language!", "Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            var languageConfig = ConfigFile.Instance.Languages.First(x => x.Name == SelectedLanguage);
            ConfigFile.Instance.Languages.Remove(languageConfig);
            RefreshLanguages();
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!SelectedLanguage.In(".NET", "C#", "VB"))
        {
            var mappings = (dgvMappings.DataSource as DataTable).Rows
               .OfType<DataRow>()
               .ToDictionary(
                   k => k.ItemArray[0].ToString(),
                   v => v.ItemArray[1].ToString());

            var languageConfig = ConfigFile.Instance.Languages.First(x => x.Name == SelectedLanguage);
            languageConfig.Mappings = mappings;
        }

        ConfigFile.Instance.SelectedLanguageName = SelectedLanguage;
        ConfigFile.Instance.Save();
        Close();
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (SelectedLanguage.In(".NET", "C#", "VB"))
        {
            dgvMappings.DataSource = null;
            dgvMappings.Enabled = false;
        }
        else
        {
            if (string.IsNullOrEmpty(SelectedLanguage) && string.IsNullOrEmpty(ConfigFile.Instance.SelectedLanguageName))
            {
                dgvMappings.DataSource = null;
            }

            var languageConfig = ConfigFile.Instance.Languages.FirstOrDefault(x => x.Name == (SelectedLanguage ?? ConfigFile.Instance.SelectedLanguageName));

            dgvMappings.DataSource = languageConfig?.Mappings
                .OrderBy(x => x.Key)
                .ToDataTable();

            dgvMappings.Enabled = true;
        }
    }
}
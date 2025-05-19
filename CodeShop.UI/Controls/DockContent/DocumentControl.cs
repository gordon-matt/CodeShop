using System.ComponentModel;

namespace CodeShop.UI;

public partial class DocumentControl : UserControl
{
    public DocumentControl()
    {
        InitializeComponent();
        ConfigFile.SelectedLanguageChanged += ConfigFile_SelectedLanguageChanged;
    }

    private void ConfigFile_SelectedLanguageChanged(string lang)
    {
        switch (lang)
        {
            case ".NET":
            case "C#": Language = FastColoredTextBoxNS.Language.CSharp; break;
            case "VB": Language = FastColoredTextBoxNS.Language.VB; break;
            default:
                {
                    if (Enum.TryParse(lang, out FastColoredTextBoxNS.Language result))
                    {
                        Language = result;
                    }
                    else
                    {
                        Language = FastColoredTextBoxNS.Language.Custom;
                    }
                }
                break;
        }
    }

    public int SelectionStart => fctDocument.SelectionStart;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public FastColoredTextBoxNS.Language Language
    {
        get => fctDocument.Language;
        set => fctDocument.Language = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ContentText
    {
        get => fctDocument.Text;
        set => fctDocument.Text = value;
    }
}
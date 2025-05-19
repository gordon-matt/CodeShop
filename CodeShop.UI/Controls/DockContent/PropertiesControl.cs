using System.ComponentModel;

namespace CodeShop.UI;

public partial class PropertiesControl : UserControl
{
    public PropertiesControl()
    {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedObject
    {
        get => (Table)propertyGrid.SelectedObject;
        set => propertyGrid.SelectedObject = value;
    }
}
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Layout;

namespace FirLib.Avalonia.PropertyGridControl;

public class PropertyGridEditControlFactory
{
    public virtual Control CreateControl(
        ConfigurablePropertyMetadata property, 
        IEnumerable<ConfigurablePropertyMetadata> allProperties)
    {
        Control? ctrlValueEdit = null;
        switch (property.ValueType)
        {
            case PropertyValueType.Bool:
                ctrlValueEdit = this.CreateCheckBoxControl(property, allProperties);
                break;

            case PropertyValueType.String:
                ctrlValueEdit = this.CreateTextBoxControl(property, allProperties);
                break;

            case PropertyValueType.Enum:
                ctrlValueEdit = this.CreateEnumControl(property, allProperties);
                break;

            default:
                throw new ArgumentOutOfRangeException($"Unsupported value {property.ValueType}");
        }

        return ctrlValueEdit;
    }

    protected virtual Control CreateCheckBoxControl(
        ConfigurablePropertyMetadata property, 
        IEnumerable<ConfigurablePropertyMetadata> allProperties)
    {
        var ctrlCheckBox = new CheckBox();
        ctrlCheckBox[!ToggleButton.IsCheckedProperty] = new Binding(
            nameof(property.ValueAccessor),
            BindingMode.TwoWay);
        ctrlCheckBox.HorizontalAlignment = HorizontalAlignment.Left;
        ctrlCheckBox.IsEnabled = !property.IsReadOnly;
        return ctrlCheckBox;
    }

    protected virtual Control CreateTextBoxControl(
        ConfigurablePropertyMetadata property,
        IEnumerable<ConfigurablePropertyMetadata> allProperties)
    {
        var ctrlTextBox = new TextBox();
        ctrlTextBox[!TextBox.TextProperty] = new Binding(
            nameof(property.ValueAccessor),
            BindingMode.TwoWay);
        ctrlTextBox.Width = double.NaN;
        ctrlTextBox.IsReadOnly = property.IsReadOnly;

        return ctrlTextBox;
    }

    protected virtual Control CreateEnumControl(
        ConfigurablePropertyMetadata property,
        IEnumerable<ConfigurablePropertyMetadata> allProperties)
    {
        var ctrlComboBox = new ComboBox();
        ctrlComboBox.Items = property.GetEnumMembers();
        ctrlComboBox[!SelectingItemsControl.SelectedItemProperty] = new Binding(
            nameof(property.ValueAccessor),
            BindingMode.TwoWay);
        ctrlComboBox.Width = double.NaN;
        ctrlComboBox.IsEnabled = !property.IsReadOnly;
        return ctrlComboBox;
    }
}
using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IComboBox : IRibbonId<IComboBox>, IRibbonExtra<IComboBox>, IRibbonImage<IComboBox>
            , IRibbonLabel<IComboBox>, IRibbonItems<IComboBox, IItems>,
            IRibbonCallback<IComboBoxCommand>
        //IComboBoxExtra, IComboBoxId, IComboBoxImage, IComboBoxLabel, IComboxBoxItems
    {
        IComboBox MaxLength(int maxLength);

        IComboBox SizeString(int comboBoxSize);

        IComboBox DynamicItems();
    }
}

using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent.Ribbon {
    public interface IGroupControls {
        IBox AddBox();

        IButton AddButton(string label);

        ICheckbox AddCheckbox(string label);

        IEditBox AddEditbox(string label);

        ILabelControl AddLabelControl();

        ISeparator AddSeparator();

        IToggleButton AddToggleButton(string label);

        IComboBox AddComboBox(string label);

        IDropDown AddDropDown(string label);

        IGallery AddGallery(string label);

        IMenu AddMenu(string label);

        IButtonGroup AddButtonGroup();
    }
}
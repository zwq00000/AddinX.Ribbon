namespace ExcelDna.Fluent.Control {
    public interface IBoxControls {
        IBox AddBox();

        IButton AddButton(string label);

        IButtonGroup AddButtonGroup();

        ICheckbox AddCheckbox(string label);

        IComboBox AddComboBox(string label);

        IDropDown AddDropDown(string label);

        IEditBox AddEditbox(string label);

        IGallery AddGallery(string label);

        ILabelControl AddLabelControl();

        IMenu AddMenu(string label);

        IToggleButton AddToggleButton(string label);
    }
}
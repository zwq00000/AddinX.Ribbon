namespace ExcelDna.Fluent.Control {
    public interface IButtonGroupControls {
        IButtonUnsize AddButton(string label);

        IToggleButtonUnsize AddToggleButton(string label);

        IGalleryUnsize AddGallery(string label);

        IMenuUnsize AddMenu(string label);
    }
}
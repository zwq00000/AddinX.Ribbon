
namespace ExcelDna.Fluent.Control {
    public interface IMenuControls {
        IButtonUnsize AddButton(string label);

        ICheckbox AddCheckbox(string label);

        IToggleButtonUnsize AddToggleButton(string label);

        IGalleryUnsize AddGallery(string label);

        IMenuUnsize AddMenu(string label);

        IMenuSeparator AddSeparator();
    }
}
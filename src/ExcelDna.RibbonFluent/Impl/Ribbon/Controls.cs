using AddinX.Fluent.Impl.Control;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Ribbon;

namespace AddinX.Fluent.Impl.Ribbon {
    public class Controls : AddInList<Control.Control>, IGroupControls, IGalleryControls, IMenuControls
        , IDropDownControls, IGalleryUnsizeControls, IMenuUnsizeControls,
        IGroupDialogBox, IButtonGroupControls, IBoxControls {
        public Controls() {
        }

        public IBox AddBox() {
            var item = new Box();
            InnerList.Add(item);
            return item;
        }

        public IButton AddButton(string label) {
            var item = new Button();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IToggleButtonUnsize IButtonGroupControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IGalleryUnsize IMenuUnsizeControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IMenuUnsize IButtonGroupControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IMenuSeparator IMenuControls.AddSeparator() {
            var item = new MenuSeparator();
            InnerList.Add(item);
            return item;
        }

        IMenuUnsize IMenuUnsizeControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IMenuUnsize IMenuControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }


        IToggleButtonUnsize IMenuUnsizeControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IGalleryUnsize IButtonGroupControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IMenuControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IMenuUnsizeControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public ICheckbox AddCheckbox(string label) {
            var item = new Checkbox();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IButtonGroupControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IToggleButtonUnsize IMenuControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IGalleryUnsize IMenuControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IEditBox AddEditbox(string label) {
            var item = new EditBox();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public ILabelControl AddLabelControl() {
            var item = new LabelControl();
            InnerList.Add(item);
            return item;
        }

        public ISeparator AddSeparator() {
            var item = new Separator();
            InnerList.Add(item);
            return item;
        }

        public IToggleButton AddToggleButton(string label) {
            var item = new ToggleButton();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IComboBox AddComboBox(string label) {
            var item = new ComboBox();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IDropDown AddDropDown(string label) {
            var item = new DropDow();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IGallery AddGallery(string label) {
            var item = new Gallery();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IMenu AddMenu(string label) {
            var item = new Menu();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        public IButtonGroup AddButtonGroup() {
            var item = new ButtonGroup();
            InnerList.Add(item);
            return item;
        }

        IMenuSeparator IMenuUnsizeControls.AddSeparator() {
            var item = new MenuSeparator();
            InnerList.Add(item);
            return item;
        }

        public IDialogBoxLauncher AddDialogBoxLauncher() {
            var item = new DialogBoxLauncher();
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IGalleryControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IDropDownControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }

        IButtonUnsize IGalleryUnsizeControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }
    }
}
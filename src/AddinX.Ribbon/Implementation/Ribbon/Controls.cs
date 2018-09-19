using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AddinX.Ribbon.Contract.Control.Box;
using AddinX.Ribbon.Contract.Control.Button;
using AddinX.Ribbon.Contract.Control.ButtonGroup;
using AddinX.Ribbon.Contract.Control.ButtonUnsize;
using AddinX.Ribbon.Contract.Control.CheckBox;
using AddinX.Ribbon.Contract.Control.ComboBox;
using AddinX.Ribbon.Contract.Control.DialogBoxLauncher;
using AddinX.Ribbon.Contract.Control.DropDown;
using AddinX.Ribbon.Contract.Control.EditBox;
using AddinX.Ribbon.Contract.Control.Gallery;
using AddinX.Ribbon.Contract.Control.GalleryUnsize;
using AddinX.Ribbon.Contract.Control.Label;
using AddinX.Ribbon.Contract.Control.Menu;
using AddinX.Ribbon.Contract.Control.MenuSeparator;
using AddinX.Ribbon.Contract.Control.MenuUnsize;
using AddinX.Ribbon.Contract.Control.Separator;
using AddinX.Ribbon.Contract.Control.ToggleButton;
using AddinX.Ribbon.Contract.Control.ToggleButtonUnsize;
using AddinX.Ribbon.Contract.Ribbon.Group;
using AddinX.Ribbon.Implementation.Control;

namespace AddinX.Ribbon.Implementation.Ribbon {
    public class Controls : AddInList, IGroupControls, IGalleryControls, IMenuControls
        , IDropDownControls, IGalleryUnsizeControls, IMenuUnsizeControls,
        IGroupDialogBox, IButtonGroupControls, IBoxControls {
        private readonly IList<Control.Control> _items;

        public Controls() {
            _items = new List<Control.Control>();
        }

        internal bool HasItems {
            get { return _items.Any(); }
        }

        public IBox AddBox() {
            var item = new Box();
            _items.Add(item);
            return item;
        }

        public IButton AddButton(string label) {
            var item = new Button();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IToggleButtonUnsize IButtonGroupControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IGalleryUnsize IMenuUnsizeControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IMenuUnsize IButtonGroupControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IMenuUnsize IMenuUnsizeControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IMenuUnsize IMenuControls.AddMenu(string label) {
            var item = new MenuUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }


        IToggleButtonUnsize IMenuUnsizeControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IGalleryUnsize IButtonGroupControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IButtonUnsize IMenuControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IButtonUnsize IMenuUnsizeControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public ICheckbox AddCheckbox(string label) {
            var item = new Checkbox();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IButtonUnsize IButtonGroupControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IToggleButtonUnsize IMenuControls.AddToggleButton(string label) {
            var item = new ToggleButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IGalleryUnsize IMenuControls.AddGallery(string label) {
            var item = new GalleryUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IEditBox AddEditbox(string label) {
            var item = new EditBox();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public ILabelControl AddLabelControl() {
            var item = new LabelControl();
            _items.Add(item);
            return item;
        }

        public ISeparator AddSeparator() {
            var item = new Separator();
            _items.Add(item);
            return item;
        }

        public IToggleButton AddToggleButton(string label) {
            var item = new ToggleButton();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IComboBox AddComboBox(string label) {
            var item = new ComboBox();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IDropDown AddDropDown(string label) {
            var item = new DropDow();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IGallery AddGallery(string label) {
            var item = new Gallery();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IMenu AddMenu(string label) {
            var item = new Menu();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        public IButtonGroup AddButtonGroup() {
            var item = new ButtonGroup();
            _items.Add(item);
            return item;
        }

        public IMenuSeparator AddSeparator(string title) {
            var item = new MenuSeparator();
            item.SetLabel(title);
            _items.Add(item);
            return item;
        }

        protected internal override XElement[] ToXml(XNamespace ns) {
            if (_items == null || !_items.Any()) {
                return null;
            }

            return _items.Select(o => o.ToXml(ns)).ToArray();
        }

        public IDialogBoxLauncherId AddDialogBoxLauncher() {
            var item = new DialogBoxLauncher();
            _items.Add(item);
            return item;
        }

        IButtonUnsize IGalleryControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IButtonUnsize IDropDownControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }

        IButtonUnsize IGalleryUnsizeControls.AddButton(string label) {
            var item = new ButtonUnsize();
            item.SetLabel(label);
            _items.Add(item);
            return item;
        }
    }
}
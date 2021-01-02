using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal {
    internal class RibbonCommandBuilder : ICommandBuilder {
        #region Implementation of ICommandBuilder

        public IBoxCommand NewBoxCommand() {
            return new BoxCommand();
        }

        public IButtonCommand NewButtonCommand() {
            return new ButtonCommand();
        }

        public IButtonGroupCommand NewButtonGroupCommand() {
            return new ButtonGroupCommand();
        }

        public ICheckBoxCommand NewCheckBoxCommand() {
            return new CheckBoxCommand();
        }

        public IComboBoxCommand NewComboBoxCommand() {
            return new ComboBoxCommand();
        }

        public IDialogBoxLauncherCommand NewDialogBoxLauncherCommand() {
            return new DialogBoxLauncherCommand();
        }

        public IDropDownCommand NewDropDownCommand() {
            return new DropDownCommand();
        }

        public IEditBoxCommand NewEditBoxCommand() {
            return new EditBoxCommand();
        }

        public IGalleryCommand NewGalleryCommand() {
            return new GalleryCommand();
        }

        public IGroupCommand NewGroupCommand() {
            return new GroupCommand();
        }

        public ILabelCommand NewLabelCommand() {
            return new LabelCommand();
        }

        public IMenuCommand NewMenuCommand() {
            return new MenuCommand();
        }

        public IRibbonCommands NewRibbonCommands() {
            return new RibbonCommands();
        }

        public ISeparatorCommand NewSeparatorCommand() {
            return new SeparatorCommand();
        }

        public IToggleButtonCommand NewToggleButtonCommand() {
            return new ToggleButtonCommand();
        }

        #endregion
    }
}
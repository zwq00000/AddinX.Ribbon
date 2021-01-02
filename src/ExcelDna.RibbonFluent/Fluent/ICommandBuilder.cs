using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent {
    public interface ICommandBuilder {
        ///<summary>
        /// create and return new <see cref="IBoxCommand"/> instance
        ///</summary>
        IBoxCommand NewBoxCommand();

        ///<summary>
        /// create and return new <see cref="IButtonCommand"/> instance
        ///</summary>
        IButtonCommand NewButtonCommand();

        ///<summary>
        /// create and return new <see cref="IButtonGroupCommand"/> instance
        ///</summary>
        IButtonGroupCommand NewButtonGroupCommand();

        ///<summary>
        /// create and return new <see cref="ICheckBoxCommand"/> instance
        ///</summary>
        ICheckBoxCommand NewCheckBoxCommand();

        ///<summary>
        /// create and return new <see cref="IComboBoxCommand"/> instance
        ///</summary>
        IComboBoxCommand NewComboBoxCommand();

        ///<summary>
        /// create and return new <see cref="IDialogBoxLauncherCommand"/> instance
        ///</summary>
        IDialogBoxLauncherCommand NewDialogBoxLauncherCommand();

        ///<summary>
        /// create and return new <see cref="IDropDownCommand"/> instance
        ///</summary>
        IDropDownCommand NewDropDownCommand();

        ///<summary>
        /// create and return new <see cref="IEditBoxCommand"/> instance
        ///</summary>
        IEditBoxCommand NewEditBoxCommand();

        ///<summary>
        /// create and return new <see cref="IGalleryCommand"/> instance
        ///</summary>
        IGalleryCommand NewGalleryCommand();

        ///<summary>
        /// create and return new <see cref="IGroupCommand"/> instance
        ///</summary>
        IGroupCommand NewGroupCommand();

        ///<summary>
        /// create and return new <see cref="ILabelCommand"/> instance
        ///</summary>
        ILabelCommand NewLabelCommand();

        ///<summary>
        /// create and return new <see cref="IMenuCommand"/> instance
        ///</summary>
        IMenuCommand NewMenuCommand();

        ///<summary>
        /// create and return new <see cref="IRibbonCommands"/> instance
        ///</summary>
        IRibbonCommands NewRibbonCommands();

        ///<summary>
        /// create and return new <see cref="ISeparatorCommand"/> instance
        ///</summary>
        ISeparatorCommand NewSeparatorCommand();

        ///<summary>
        /// create and return new <see cref="IToggleButtonCommand"/> instance
        ///</summary>
        IToggleButtonCommand NewToggleButtonCommand();
    }
}
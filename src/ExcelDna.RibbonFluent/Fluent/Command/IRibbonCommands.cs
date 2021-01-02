namespace ExcelDna.Fluent.Command {
    public interface IRibbonCommands {

        /// <summary>
        /// Create and return new  <see cref="IButtonCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IButtonCommand AddButtonCommand(string controlId);

        /// <summary>
        /// Create and return new <see cref="ICheckBoxCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        ICheckBoxCommand AddCheckBoxCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IComboBoxCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IComboBoxCommand AddComboBoxCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IDropDownCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IDropDownCommand AddDropDownCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IEditBoxCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IEditBoxCommand AddEditBoxCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IGalleryCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IGalleryCommand AddGalleryCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="ILabelCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        ILabelCommand AddLabelCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="ISeparatorCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        ISeparatorCommand AddSeparatorCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IToggleButtonCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IToggleButtonCommand AddToggleButtonCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IMenuCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IMenuCommand AddMenuCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IBoxCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IBoxCommand AddBoxCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IButtonGroupCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IButtonGroupCommand AddButtonGroupCommand(string controlId);

        /// <summary>
        /// Create and return new  <see cref="IDialogBoxLauncherCommand"/>
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        IDialogBoxLauncherCommand AddDialogBoxLauncherCommand(string controlId);

        /// <summary>
        /// Find <see cref="ICommand"/> instance By control id 
        /// </summary>
        /// <param name="controlId">ribbon control id</param>
        /// <returns></returns>
        ICommand Find(string controlId);
    }
}
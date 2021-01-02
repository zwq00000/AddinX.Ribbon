using System;

namespace ExcelDna.Fluent.Command {
    public interface ICheckBoxCommand : IButtonRegularCommand<ICheckBoxCommand> {
        ICheckBoxCommand OnChecked(Action<bool> action);

        /// <summary>
        /// determined whether the check-box is checked or not when the application is launched.
        /// </summary>
        /// <param name="checkedFunc">a boolean value</param>
        /// <returns>Fluent Builder</returns>
        ICheckBoxCommand GetChecked(Func<bool> checkedFunc);
    }
}
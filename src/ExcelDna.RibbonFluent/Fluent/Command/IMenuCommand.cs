using System;

namespace ExcelDna.Fluent.Command {
    public interface IMenuCommand : IControlCommand<IMenuCommand> {
        /// <summary>
        /// add getSize Callback
        /// </summary>
        /// <param name="sizeFunc"></param>
        /// <returns></returns>
        IMenuCommand GetSize(Func<ControlSize> sizeFunc);
    }
}
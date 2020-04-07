using System;

namespace ExcelDna.Fluent.Command {
    public interface IButtonCommand : IButtonRegularCommand<IButtonCommand> {
        IButtonCommand OnAction(Action action);
    }
}
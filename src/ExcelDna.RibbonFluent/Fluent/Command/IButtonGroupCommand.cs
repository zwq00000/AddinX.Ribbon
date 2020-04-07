using System;

namespace ExcelDna.Fluent.Command {
    public interface IButtonGroupCommand : ICommand {
        void GetVisible(Func<bool> condition);
    }
}
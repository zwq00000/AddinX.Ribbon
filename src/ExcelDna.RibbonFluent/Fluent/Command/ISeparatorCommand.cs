using System;

namespace ExcelDna.Fluent.Command {
    public interface ISeparatorCommand : ICommand {
        void GetVisible(Func<bool> condition);
    }
}
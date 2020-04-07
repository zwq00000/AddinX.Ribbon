using System;

namespace ExcelDna.Fluent.Command {
    public interface IBoxCommand : ICommand {
        void GetVisible(Func<bool> condition);
    }
}
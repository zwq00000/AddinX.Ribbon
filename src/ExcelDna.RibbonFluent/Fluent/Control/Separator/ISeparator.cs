using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface ISeparator : IRibbonIdQ<ISeparator>, IRibbonCallback<ISeparatorCommand> {
    }
}
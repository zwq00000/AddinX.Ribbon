using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface ICheckbox : IRibbonId<ICheckbox>, IRibbonExtra<ICheckbox>,
        IRibbonCallback<ICheckBoxCommand> {
    }
}
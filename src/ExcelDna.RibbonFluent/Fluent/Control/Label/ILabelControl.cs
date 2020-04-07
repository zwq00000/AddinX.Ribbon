using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface ILabelControl : IRibbonId<ILabelControl>, IRibbonExtra<ILabelControl>,
        IRibbonCallback<ILabelCommand> {
    }
}
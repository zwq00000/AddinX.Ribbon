using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IBox : IRibbonIdQ<IBox>, IRibbonStyle<IBox>, IRibbonItems<IBox, IBoxControls>,
        IRibbonCallback<IBoxCommand> {
    }
}
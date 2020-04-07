using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IEditBox : IRibbonId<IEditBox>, IRibbonListExtra<IEditBox>, IRibbonImage<IEditBox>,
        IRibbonCallback<IEditBoxCommand> {
    }
}
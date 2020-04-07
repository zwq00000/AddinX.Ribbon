using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IButtonGroup : IRibbonId<IButtonGroup>, IRibbonItems<IButtonGroup, IButtonGroupControls>,
        IRibbonCallback<IButtonGroupCommand> {
    }
}
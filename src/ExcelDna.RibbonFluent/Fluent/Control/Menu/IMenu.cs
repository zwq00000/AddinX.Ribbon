using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IMenu : IRibbonIdQ<IMenu>, IRibbonExtra<IMenu>, IRibbonImage<IMenu>, IRibbonSize<IMenu>,
        IRibbonItemSize<IMenu>, IRibbonLabel<IMenu>, IRibbonItems<IMenu, IMenuControls>,
        IRibbonCallback<IMenuCommand> {
    }
}
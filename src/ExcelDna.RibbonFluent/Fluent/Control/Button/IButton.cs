using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IButton : IRibbonId<IButton>, IRibbonImage<IButton>,
        IRibbonSize<IButton>, IRibbonLabel<IButton>, IRibbonExtra<IButton>,
        IRibbonCallback<IButtonCommand> {
        IButton Description(string description);
    }
}
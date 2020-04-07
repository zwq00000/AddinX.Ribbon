using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IToggleButton : IRibbonId<IToggleButton>, IRibbonLabel<IToggleButton>
        , IRibbonSize<IToggleButton>, IRibbonImage<IToggleButton>, IRibbonExtra<IToggleButton>,
        IRibbonCallback<IToggleButtonCommand> {
    }
}
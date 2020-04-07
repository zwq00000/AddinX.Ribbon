using System;
using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IDropDown : IRibbonId<IDropDown>, IRibbonExtra<IDropDown>, IRibbonImage<IDropDown>,
        IRibbonItemImage<IDropDown>, IRibbonItemLabel<IDropDown>, IRibbonLabel<IDropDown>,
        IRibbonDynamic<IDropDown, IItems>,
        IRibbonCallback<IDropDownCommand> {
        IDropDown Buttons(Action<IDropDownControls> items);
    }
}
using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent.Ribbon {
    public interface IGroup : IRibbonId<IGroup>, IRibbonExtra<IGroup>, IRibbonItems<IGroup, IGroupControls>,
            IRibbonCallback<IGroupCommand>
        //IGroupId , IGroupItems, IGroupExtra,
    {
        IGroup DialogBoxLauncher(Action<IGroupDialogBox> dialogBox);
    }
}
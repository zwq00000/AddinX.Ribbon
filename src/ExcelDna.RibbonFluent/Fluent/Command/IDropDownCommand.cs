using System;

namespace ExcelDna.Fluent.Command {
    public interface IDropDownCommand : IDynamicItemsCommand<IDropDownCommand> {
        IDropDownCommand OnItemAction(Action<int> act);

        IDropDownCommand ItemSelectionIndex(Func<int> selectedItemIndex);
    }
}
using System;

namespace ExcelDna.Fluent.Command {
    public interface IGalleryCommand : IDynamicItemsCommand<IGalleryCommand> {
        IGalleryCommand OnItemAction(Action<int> act);

        IGalleryCommand ItemSelectionIndex(Func<int> selectedItemIndex);
    }
}
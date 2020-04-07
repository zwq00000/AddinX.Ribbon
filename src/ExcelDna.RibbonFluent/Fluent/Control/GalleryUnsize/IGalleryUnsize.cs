using System;
using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IGalleryUnsize : IRibbonId<IGalleryUnsize>, IRibbonGalleryExtra<IGalleryUnsize>,
        IRibbonImage<IGalleryUnsize>, IRibbonItemImage<IGalleryUnsize>, IRibbonItemLabel<IGalleryUnsize>,
        IRibbonLabel<IGalleryUnsize>, IRibbonItems<IGalleryUnsize, IItems>, IRibbonCallback<IGalleryCommand> {
        IGalleryUnsize Buttons(Action<IGalleryUnsizeControls> items);
    }
}
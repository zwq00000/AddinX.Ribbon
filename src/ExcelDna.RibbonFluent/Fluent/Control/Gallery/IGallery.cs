using System;
using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IGallery : IRibbonId<IGallery>, IRibbonGalleryExtra<IGallery>,
        IRibbonImage<IGallery>, IRibbonItemImage<IGallery>, IRibbonItemLabel<IGallery>,
        IRibbonLabel<IGallery>, IRibbonDynamic<IGallery, IItems>, IRibbonSize<IGallery>,
        IRibbonCallback<IGalleryCommand> {
        IGallery Buttons(Action<IGalleryControls> items);
    }
}
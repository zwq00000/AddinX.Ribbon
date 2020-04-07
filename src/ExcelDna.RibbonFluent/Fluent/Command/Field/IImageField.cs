using System;
using System.Drawing;

namespace ExcelDna.Fluent.Command.Field {
    public interface IImageField {
        /// <summary>
        /// getImage
        /// »Øµ÷
        /// VBA£ºSub GetImage(control As IRibbonControl, ByRef returnedBitmap)
        /// C#£ºBitmap GetImage(IRibbonControl control)
        /// </summary>
        Func<Image> getImage { get; }
    }
}
using System;
using System.Drawing;

namespace ExcelDna.Fluent.Command.Field {
    public interface IImageField {
        /// <summary>
        /// getImage
        /// �ص�
        /// VBA��Sub GetImage(control As IRibbonControl, ByRef returnedBitmap)
        /// C#��Bitmap GetImage(IRibbonControl control)
        /// </summary>
        Func<Image> getImage { get; }
    }
}
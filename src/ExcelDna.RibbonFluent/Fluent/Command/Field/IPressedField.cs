using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface IPressedField {
        /// <summary>
        /// getPressed
        /// »Øµ÷
        /// VBA£ºSub GetPressed(control As IRibbonControl, ByRef returnedVal)
        /// C#£ºbool GetPressed(IRibbonControl control)
        /// </summary>
        Func<bool> getPressed { get; set; }
    }
}
using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface ILabelField {
        /// <summary>
        /// getLabel
        /// 回调
        /// VBA：Sub GetLabel(control As IRibbonControl, ByRef returnedVal)
        /// C#：string GetLabel(IRibbonControl control)
        /// </summary>
        Func<string> getLabel { get; set; }
    }
}
using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface IDescriptionField {
        /// <summary>
        /// getDescription
        /// �ص�
        /// VBA��Sub GetDescription(control As IRibbonControl, ByRef returnedVal)
        /// C#��string GetDescription(IRibbonControl control)
        /// </summary>
        Func<string> getDescription { get; set; }
    }
}
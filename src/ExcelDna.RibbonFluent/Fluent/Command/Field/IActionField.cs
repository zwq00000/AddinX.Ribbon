using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface IActionField {
        /// <summary>
        /// onAction 
        /// 回调
        /// VBA：Sub OnAction(control As IRibbonControl, itemID As String, itemIndex As Integer)
        /// C#：void OnAction(IRibbonControl control, string itemID, int itemIndex)
        /// </summary>
        Action onAction { get; set; }
    }
}
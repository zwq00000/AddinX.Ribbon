using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal.Control {
    public class LabelControl : Control<ILabelControl, ILabelCommand>, ILabelControl {
        public LabelControl() : base("labelControl") {
        }


        protected override ILabelControl Interface => this;


        #region Implementation of IRibbonCallback<out ILabelControl,out ILabelCommand>

        public void Callback(Action<ILabelCommand> builder) {
            builder(GetCommand<LabelCommand>());
        }

        #endregion
    }
}
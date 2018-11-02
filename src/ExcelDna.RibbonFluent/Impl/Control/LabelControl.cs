using System;
using AddinX.Fluent.Impl.Command;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Control.Label;

namespace AddinX.Fluent.Impl.Control {
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
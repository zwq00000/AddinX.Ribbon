using System;
using AddinX.Fluent.Impl.Command;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Separator : Control<ISeparator, ISeparatorCommand>, ISeparator {
        public Separator() : base("separator") {
        }

        protected override ISeparator Interface => this;

        #region Implementation of IRibbonCallback<ISeparatorCommand>

        public void Callback(Action<ISeparatorCommand> builder) {
            builder?.Invoke(GetCommand<SeparatorCommand>());
        }

        #endregion
    }
}
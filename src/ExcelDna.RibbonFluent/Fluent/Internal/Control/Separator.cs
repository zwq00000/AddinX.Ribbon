using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal.Control {
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
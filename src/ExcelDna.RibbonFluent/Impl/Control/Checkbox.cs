using System;
using AddinX.Fluent.Impl.Command;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Checkbox : Control<ICheckbox, ICheckBoxCommand>, ICheckbox {
        public Checkbox() : base("checkBox") {
        }

        protected override ICheckbox Interface => this;

        #region Implementation of IRibbonCallback<out ICheckBoxCommand>

        public void Callback(Action<ICheckBoxCommand> builder) {
            builder(GetCommand<CheckBoxCommand>());
        }

        #endregion
    }
}
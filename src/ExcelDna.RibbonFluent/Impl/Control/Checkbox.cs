using System;
using AddinX.Fluent.Impl.Command;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Control.CheckBox;

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
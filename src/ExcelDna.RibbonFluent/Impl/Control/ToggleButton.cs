using System;
using AddinX.Fluent.Impl.Command;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Control.ToggleButton;

namespace AddinX.Fluent.Impl.Control {
    public class ToggleButton : Control<IToggleButton, IToggleButtonCommand>, IToggleButton {
        public ToggleButton() : base("toggleButton") {
            NoImage();
            NormalSize();
        }

        protected override IToggleButton Interface => this;

        #region Implementation of IRibbonCallback<IToggleButtonCommand>

        public void Callback(Action<IToggleButtonCommand> builder) {
            builder?.Invoke(GetCommand<ToggleButtonCommand>());
        }

        #endregion
    }
}
using System;
using AddinX.Fluent.Impl.Command;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

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
using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal.Control {
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
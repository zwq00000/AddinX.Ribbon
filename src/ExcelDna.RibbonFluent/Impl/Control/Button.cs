using System;
using AddinX.Fluent.Impl.Command;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Button : Control<IButton, IButtonCommand>, IButton {
        public Button() : base("button") {
            NormalSize();
            NoImage();
        }

        protected override IButton Interface => this;

        #region Implementation of IRibbonCommands<out IButtonCommand>

        public void Callback(Action<IButtonCommand> builder) {
            builder(GetCommand<ButtonCommand>());
        }

        #endregion
    }
}
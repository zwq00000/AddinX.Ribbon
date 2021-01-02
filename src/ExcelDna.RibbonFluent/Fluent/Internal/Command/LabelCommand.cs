using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Internal.Command {
    public class LabelCommand : ControlCommand<ILabelCommand>, ILabelCommand {
        #region Implementation of ICommand

        protected override ILabelCommand Interface => this;

        #endregion
    }
}
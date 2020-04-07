using ExcelDna.Fluent.Command;

namespace AddinX.Fluent.Impl.Command {
    public class LabelCommand : ControlCommand<ILabelCommand>, ILabelCommand {
        #region Implementation of ICommand

        protected override ILabelCommand Interface => this;

        #endregion
    }
}
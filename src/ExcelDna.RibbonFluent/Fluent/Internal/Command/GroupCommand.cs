using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace ExcelDna.Fluent.Internal.Command {
    public class GroupCommand : ControlCommand<IGroupCommand>, IGroupCommand, IVisibleField {

        protected override IGroupCommand Interface => this;

    }
}
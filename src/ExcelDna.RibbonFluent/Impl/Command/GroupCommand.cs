using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;

namespace AddinX.Fluent.Impl.Command {
    public class GroupCommand : ControlCommand<IGroupCommand>, IGroupCommand, IVisibleField {

        protected override IGroupCommand Interface => this;

    }
}
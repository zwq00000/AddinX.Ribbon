using AddinX.Fluent.Impl.Control;
using AddinX.Ribbon.Contract.Ribbon.Group;

namespace AddinX.Fluent.Impl.Ribbon {
    public class Groups : AddInList<Group>, IGroups {
        public Groups() {
        }

        public IGroup AddGroup(string label) {
            var tab = new Group();
            tab.SetLabel(label);
            InnerList.Add(tab);
            return tab;
        }
    }
}
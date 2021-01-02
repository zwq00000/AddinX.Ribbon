using ExcelDna.Fluent.Internal.Control;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Internal.Ribbon {
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
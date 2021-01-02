using ExcelDna.Fluent.Internal.Control;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Internal.Ribbon {
    public class TabSetTabs : AddInList<Tab>, ITabs {
        public TabSetTabs() {
        }

        public ITab AddTab(string label) {
            var tab = new Tab();
            tab.SetLabel(label);
            InnerList.Add(tab);
            return tab;
        }
    }
}
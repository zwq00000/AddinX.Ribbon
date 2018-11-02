using AddinX.Fluent.Impl.Control;
using AddinX.Ribbon.Contract.Ribbon.Tab;

namespace AddinX.Fluent.Impl.Ribbon {
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
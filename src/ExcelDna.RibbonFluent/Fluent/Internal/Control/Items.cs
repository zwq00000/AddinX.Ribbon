using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent.Internal.Control {
    public class Items : AddInList<Item>, IItems {
        public Items() {
        }

        public IItem AddItem(string label) {
            var item = new Item();
            item.SetLabel(label);
            InnerList.Add(item);
            return item;
        }
    }
}
using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent.Internal.Control {
    public class Item : Control<IItem>, IItem {
        public Item() : base("item") {
            //NoImage();
        }

        protected override IItem Interface => this;
    }
}
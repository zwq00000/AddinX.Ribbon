using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class MenuSeparator : Control<IMenuSeparator>, IMenuSeparator {
        public MenuSeparator() : base("menuSeparator") {
        }

        protected override IMenuSeparator Interface => this;

        #region Implementation of IMenuSeparator

        public IMenuSeparator SetTitle(string title) {
            base.SetAttribute("title", title);
            return Interface;
        }

        #endregion
    }
}
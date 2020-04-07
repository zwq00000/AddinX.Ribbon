using System;
using AddinX.Fluent.Impl.Control;
using ExcelDna.Fluent.Ribbon;

namespace AddinX.Fluent.Impl.Ribbon {
    public class Tab : ControlContainer<ITab, Groups>, ITab {
        public Tab() : base("tab") {
        }


        protected override ITab Interface => this;

        public ITab Groups(Action<IGroups> value) {
            value.Invoke(InnerItems);
            return this;
        }
    }
}
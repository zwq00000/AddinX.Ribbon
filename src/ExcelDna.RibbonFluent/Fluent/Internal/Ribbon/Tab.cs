using System;
using ExcelDna.Fluent.Internal.Control;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Internal.Ribbon {
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
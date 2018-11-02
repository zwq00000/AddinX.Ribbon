using System;
using AddinX.Fluent.Impl.Control;
using AddinX.Ribbon.Contract.Ribbon.Group;
using AddinX.Ribbon.Contract.Ribbon.Tab;

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
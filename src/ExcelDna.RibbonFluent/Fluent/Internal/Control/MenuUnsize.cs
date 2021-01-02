using System;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Ribbon;

namespace ExcelDna.Fluent.Internal.Control {
    public class MenuUnsize : ControlContainer<IMenuUnsize, Controls>, IMenuUnsize {
        public MenuUnsize() : base("menu") {
            NoImage();
        }


        protected override IMenuUnsize Interface => this;


        public IMenuUnsize Items(Action<IMenuUnsizeControls> builder) {
            builder?.Invoke(base.InnerItems);
            return this;
        }
    }
}
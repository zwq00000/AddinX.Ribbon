using System;
using System.Xml.Linq;
using AddinX.Fluent.Impl.Command;
using AddinX.Fluent.Impl.Ribbon;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class Box : Control<IBox, IBoxCommand>, IBox {
        private const string tag_boxStyle = "boxStyle";
        private readonly Controls _items;

        public Box() : base("box") {
            _items = new Controls();
        }

        protected internal override void SetRegister(ICallbackRegister register) {
            base.SetRegister(register);
            _items?.SetRegister(register);
        }

        protected override IBox Interface => this;

        public IBox HorizontalDisplay() {
            SetAttribute(tag_boxStyle, BoxStyle.Horizontal);
            return this;
        }

        public IBox VerticalDisplay() {
            SetAttribute(tag_boxStyle, BoxStyle.Vertical);
            return this;
        }

        public IBox Items(Action<IBoxControls> builder) {
            builder?.Invoke(_items);
            return this;
        }

        protected internal override XElement ToXml(XNamespace ns) {
            var element = base.ToXml(ns);
            element.AddControls(_items, ns);
            return element;
        }


        #region Implementation of IRibbonCallback<out IBoxCommand>

        public void Callback(Action<IBoxCommand> builder) {
            builder(GetCommand<BoxCommand>());
        }

        #endregion
    }
}
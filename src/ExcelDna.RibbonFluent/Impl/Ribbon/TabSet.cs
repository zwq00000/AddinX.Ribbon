using System;
using System.Xml.Linq;
using AddinX.Fluent.Impl.Control;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Ribbon;

namespace AddinX.Fluent.Impl.Ribbon {
    public class TabSet : AddInElement, ITabSet {
        private readonly TabSetTabs _tabs;
        private readonly IElementId _id;

        public TabSet() : base("tabSet") {
            _id = new ElementId();
            _tabs = new TabSetTabs();
        }

        protected internal override void SetRegister(ICallbackRegister register) {
            base.SetRegister(register);
            _tabs.SetRegister(register);
        }

        protected internal override XElement ToXml(XNamespace ns) {
            var tmpId = (ElementId) _id;

            var element = new XElement(ns + ElementName
                , new XAttribute(tmpId.Type.ToString(), tmpId.Value)
            );

            element.AddControls((AddInList) _tabs, ns);
            return element;
        }

        public void Tabs(Action<ITabs> value) {
            value.Invoke(_tabs);
        }

        public ITabSetItem IdMso(TabSetId name) {
            _id.SetMicrosoftId(name.ToString());
            return this;
        }
    }
}
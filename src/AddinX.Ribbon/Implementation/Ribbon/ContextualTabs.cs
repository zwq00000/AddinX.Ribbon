﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AddinX.Ribbon.Contract;
using AddinX.Ribbon.Contract.Ribbon;
using AddinX.Ribbon.Contract.Ribbon.TabSet;
using AddinX.Ribbon.Implementation.Control;

namespace AddinX.Ribbon.Implementation.Ribbon {
    public class ContextualTabs : AddInElement, IContextualTabs {
        private readonly IList<ITabSet> _items;
        private readonly ICallbackRigister _register;

        public ContextualTabs(ICallbackRigister register) :base("contextualTabs") {
            _register = register;
            _items = new List<ITabSet>();
        }

        public IContextualTabs AddTabSet(Action<ITabSetId> value) {
            var item = new TabSet(_register);
            value.Invoke(item);
            _items.Add(item);
            return this;
        }

        protected internal override XElement ToXml(XNamespace ns) {
            if (_items == null || !_items.Any()) {
                return null;
            }

            return new XElement(ns + ElementName
                , _items.Select(o => ((AddInElement) o).ToXml(ns))
            );
        }
    }
}
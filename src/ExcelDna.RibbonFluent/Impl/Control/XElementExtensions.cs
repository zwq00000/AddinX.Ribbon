using System.Linq;
using System.Xml.Linq;
using AddinX.Fluent.Impl.Ribbon;

namespace AddinX.Fluent.Impl.Control {
    internal static class XElementExtensions {
        public static void AddControls(this XElement element, Controls items, XNamespace ns) {
            if (items == null) {
                return;
            }

            foreach (var item in items.ToXml(ns)) {
                element.Add(item);
            }
        }

        public static void AddControls<T>(this XElement element, AddInList<T> items, XNamespace ns)
            where T : AddInElement {
            if (items == null) {
                return;
            }

            foreach (var item in items) {
                element.Add(item.ToXml(ns));
            }
        }

        public static void AddControls(this XElement element, AddInList list, XNamespace ns) {
            var items = list?.ToXml(ns).ToArray();
            if (items != null && items.Any()) {
                foreach (var item in items) {
                    element.Add(item);
                }
            }
        }
    }
}
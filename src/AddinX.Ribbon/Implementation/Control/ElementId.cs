using System.Xml.Linq;
using AddinX.Ribbon.Contract.Control;
using AddinX.Ribbon.Contract.Enums;

namespace AddinX.Ribbon.Implementation.Control {
    public class ElementId : IElementId {
        private static int _autoId = 1;
        protected internal IdType Type = IdType.id;
        protected internal string Value;

        public ElementId() {
            Value = $"id_{_autoId++:0000}";
        }

        public IElementId SetId(string name) {
            Value = name;
            Type = IdType.id;
            return this;
        }

        public IElementId SetMicrosoftId(string name) {
            Value = name;
            Type = IdType.idMso;
            return this;
        }

        public IElementId SetNamespaceId(string namespaceKey, string name) {
            Value = namespaceKey + ":" + name;
            Type = IdType.idQ;
            return this;
        }

        public string Id => Value;

        #region Overrides of Object

        /// <summary>返回表示当前 <see cref="T:System.Object" /> 的 <see cref="T:System.String" />。</summary>
        /// <returns>
        /// <see cref="T:System.String" />，表示当前的 <see cref="T:System.Object" />。</returns>
        public override string ToString() {
            return $"{Type}={Value}";
        }

        #endregion

        internal XAttribute ToXml() {
            return new XAttribute(Type.ToString(), Value);
        }
    }
}
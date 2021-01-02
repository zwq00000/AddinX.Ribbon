using System;
using System.Xml.Linq;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace ExcelDna.Fluent.Internal.Command {
    public class EditBoxCommand : ControlCommand<IEditBoxCommand>, IEditBoxCommand, ITextField {
    
        public IEditBoxCommand GetText(Func<string> defaultValue) {
            getText = defaultValue;
            return this;
        }

        public IEditBoxCommand OnChange(Action<string> newText) {
            onChange = newText;
            return this;
        }

        #region Implementation of ICommand

        protected override IEditBoxCommand Interface => this;

        /// <summary>
        ///     写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        protected internal override void WriteXml(XElement element) {
            base.WriteXml(element);
            AddOnChange(element, onChange);
            AddGetText(element, getText);
        }

        #endregion

        public Func<string> getText { get; set; }
        public Action<string> onChange { get; set; }
    }
}
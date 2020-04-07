using System;
using System.Xml.Linq;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace AddinX.Fluent.Impl.Command {
    public class SeparatorCommand : AbstractCommand, ISeparatorCommand, IVisibleField {
        public void GetVisible(Func<bool> condition) {
            getVisible = condition;
        }

        #region Implementation of ICommand

        /// <summary>
        ///     写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        protected internal override void WriteXml(XElement element) {
            AddGetVisible(element,getVisible);
        }

        #endregion

        public Func<bool> getVisible { get; set; }
    }
}
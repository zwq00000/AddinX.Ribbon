using System;
using System.Xml.Linq;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace AddinX.Fluent.Impl.Command {
    public class MenuCommand : ControlCommand<IMenuCommand>, IMenuCommand, ISizeField{

        protected override IMenuCommand Interface => this;

        protected internal override void WriteXml(XElement element) {
            base.WriteXml(element);
            AddGetSize(element, getSize);
        }

        #region Implementation of IMenuCommand

        /// <summary>
        /// add getSize Callback
        /// </summary>
        /// <param name="sizeFunc"></param>
        /// <returns></returns>
        public IMenuCommand GetSize(Func<ControlSize> sizeFunc) {
            getSize = sizeFunc;
            return Interface;
        }

        #endregion

        #region Implementation of ISizeField

        public Func<ControlSize> getSize { get; set; }

        #endregion
    }
}
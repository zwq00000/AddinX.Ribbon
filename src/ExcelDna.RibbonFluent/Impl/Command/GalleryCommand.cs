using System;
using System.Xml.Linq;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Command.Field;

namespace AddinX.Fluent.Impl.Command {
    public class GalleryCommand : DynamicItemsCommand<IGalleryCommand>, 
        IGalleryCommand, IDropDownField {

        public Action<int> onItemAction { get; set; }
        public Func<int> getSelectedItemIndex { get; set; }


        public IGalleryCommand OnItemAction(Action<int> act) {
            onItemAction = act;
            return this;
        }

        public IGalleryCommand ItemSelectionIndex(Func<int> selectedItemIndex) {
            getSelectedItemIndex = selectedItemIndex;
            return this;
        }

        #region Implementation of ICommand

        protected override IGalleryCommand Interface => this;

        /// <summary>
        ///     写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        protected internal override void WriteXml(XElement element) {
            base.WriteXml(element);
            AddOnItemAction(element, onItemAction);
            AddGetSelectedItemIndex(element, getSelectedItemIndex);
        }

        #endregion
    }
}
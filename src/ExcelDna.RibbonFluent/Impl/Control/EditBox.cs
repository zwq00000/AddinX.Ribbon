using System;
using AddinX.Fluent.Impl.Command;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class EditBox : Control<IEditBox, IEditBoxCommand>, IEditBox {
        public EditBox() : base("editBox") {
            NoImage();
            MaxLength(15);
            SizeString(15);
        }

        protected override IEditBox Interface => this;

        #region Implementation of IRibbonCallback<out IEditBox,out IEditBoxCommand>

        public void Callback(Action<IEditBoxCommand> builder) {
            base.BuildCallback<EditBoxCommand>(builder);
        }

        #endregion
    }
}
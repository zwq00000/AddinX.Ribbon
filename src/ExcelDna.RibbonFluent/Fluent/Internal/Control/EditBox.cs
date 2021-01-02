using System;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal.Control {
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
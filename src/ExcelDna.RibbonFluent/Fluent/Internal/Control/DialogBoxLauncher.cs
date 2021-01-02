using System;
using System.Xml.Linq;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Internal.Command;

namespace ExcelDna.Fluent.Internal.Control {
    public class DialogBoxLauncher : Control<IDialogBoxLauncher, IDialogBoxLauncherCommand>, IDialogBoxLauncher {
        private readonly ButtonUnsize _btn;

        public DialogBoxLauncher() : base("dialogBoxLauncher") {
            _btn = new ButtonUnsize();
            _btn.HideLabel();
            _btn.NoImage();
        }

        protected internal override void SetRegister(ICallbackRegister register) {
            base.SetRegister(register);
            _btn.SetRegister(register);
        }

        protected internal override XElement ToXml(XNamespace ns) {
            var element = new XElement(ns + ElementName,
                _btn.ToXml(ns)
            );
            return element;
        }

        protected override IDialogBoxLauncher Interface => this;


        #region Implementation of IRibbonCallback<out IDialogBoxLauncher,out IDialogBoxLauncherCommand>

        public void Callback(Action<IDialogBoxLauncherCommand> builder) {
            builder(GetCommand<DialogBoxLauncherCommand>());
        }

        #endregion
    }
}
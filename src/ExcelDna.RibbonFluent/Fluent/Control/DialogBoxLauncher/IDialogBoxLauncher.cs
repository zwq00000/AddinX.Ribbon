using ExcelDna.Fluent.Command;

namespace ExcelDna.Fluent.Control {
    public interface IDialogBoxLauncher : IRibbonIdQ<IDialogBoxLauncher>, IRibbonExtra<IDialogBoxLauncher>,
        IRibbonCallback<IDialogBoxLauncherCommand> {
    }
}
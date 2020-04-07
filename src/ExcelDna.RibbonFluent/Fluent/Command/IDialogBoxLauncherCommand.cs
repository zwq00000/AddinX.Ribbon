using System;

namespace ExcelDna.Fluent.Command {
    public interface IDialogBoxLauncherCommand : ICommand {
        IDialogBoxLauncherCommand OnAction(Action act);

        IDialogBoxLauncherCommand GetVisible(Func<bool> condition);

        IDialogBoxLauncherCommand GetEnabled(Func<bool> condition);
    }
}
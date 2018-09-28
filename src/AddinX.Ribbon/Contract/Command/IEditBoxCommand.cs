﻿using System;

namespace AddinX.Ribbon.Contract.Command {
    public interface IEditBoxCommand : ICommand {
        IEditBoxCommand GetVisible(Func<bool> condition);

        IEditBoxCommand GetEnabled(Func<bool> condition);

        /// <summary>
        /// determined what is the default text displayed in the textboxc when the application is launched.
        /// </summary>
        /// <param name="defaultValue">a string value</param>
        /// <returns>Fluent Builder</returns>
        IEditBoxCommand GetText(Func<string> defaultValue);

        IEditBoxCommand OnChange(Action<string> newText);
    }
}
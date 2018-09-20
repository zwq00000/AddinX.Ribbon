﻿using System;
using System.Xml.Linq;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;

namespace AddinX.Ribbon.Implementation.Command {
    public class DialogBoxLauncherCommand : IDialogBoxLauncherCommand, IVisibleField, IEnabledField, IActionField {
        public Func<bool> IsVisibleField { get; private set; }
        public Func<bool> IsEnabledField { get; private set; }
        public Action OnActionField { get; private set; }

        public DialogBoxLauncherCommand() {
            //IsVisibleField = () => true;
            //IsEnabledField = () => true;
        }

        public IDialogBoxLauncherCommand Action(Action act) {
            OnActionField = act;
            return this;
        }

        public IDialogBoxLauncherCommand IsVisible(Func<bool> condition) {
            IsVisibleField = condition;
            return this;
        }

        public IDialogBoxLauncherCommand IsEnabled(Func<bool> condition) {
            IsEnabledField = condition;
            return this;
        }

        #region Implementation of ICommand

        /// <summary>
        /// 写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        public void WriteCallbackXml(XElement element) {
            element.AddCallbackAttribute("onAction", OnActionField);
            element.AddCallbackAttribute("getEnabled", IsEnabledField);
            element.AddCallbackAttribute("getVisible", IsVisibleField);
        }

        #endregion
    }
}
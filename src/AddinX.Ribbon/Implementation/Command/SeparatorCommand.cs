﻿using System;
using System.Xml.Linq;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;

namespace AddinX.Ribbon.Implementation.Command {
    class SeparatorCommand : ISeparatorCommand, IVisibleField {
        public Func<bool> IsVisibleField { get; private set; }

        public SeparatorCommand() {
            //IsVisibleField = () => true;
        }

        public void IsVisible(Func<bool> condition) {
            IsVisibleField = condition;
        }

        #region Implementation of ICommand

        /// <summary>
        /// 写入回调Xml属性
        /// </summary>
        /// <param name="element"></param>
        public void WriteCallbackXml(XElement element) {
            element.AddCallbackAttribute("getVisible", IsVisibleField);
        }

        #endregion
    }
}
﻿using System;
using System.Xml.Linq;
using AddinX.Fluent.Impl.Command;
using AddinX.Fluent.Impl.Control;
using ExcelDna.Fluent;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Ribbon;

namespace AddinX.Fluent.Impl.Ribbon {
    public class Group : ControlContainer<IGroup, Controls>, IGroup {
        private Controls _boxLauncher;

        public Group() : base("group") {
        }

        #region Overrides of AddInElement

        protected internal override void SetRegister(ICallbackRegister register) {
            base.SetRegister(register);
            _boxLauncher?.SetRegister(register);
        }

        #endregion

        protected internal override XElement ToXml(XNamespace ns) {
            var element = base.ToXml(ns);

            if (_boxLauncher != null) {
                element.AddControls((AddInList) _boxLauncher, ns);
            }

            return element;
        }

        protected override IGroup Interface => this;

        public IGroup DialogBoxLauncher(Action<IGroupDialogBox> dialogBox) {
            _boxLauncher = new Controls();
            dialogBox.Invoke(_boxLauncher);
            return this;
        }

        #region Implementation of IRibbonCallback<out IGroup,out IGroupCommand>

        public void Callback(Action<IGroupCommand> builder) {
            builder?.Invoke(GetCommand<GroupCommand>());
        }

        public void Callback(IGroupCommand command) {
            base.SetCommand(command);
        }

        #endregion

        #region Implementation of IRibbonItems<out IGroup,out IGroupControls>

        public IGroup Items(Action<IGroupControls> builder) {
            builder?.Invoke(base.InnerItems);
            return this;
        }

        #endregion
    }
}
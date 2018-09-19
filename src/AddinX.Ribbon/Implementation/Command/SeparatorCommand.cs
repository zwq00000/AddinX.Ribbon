﻿using System;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;

namespace AddinX.Ribbon.Implementation.Command {
    class SeparatorCommand : ISeparatorCommand, IVisibleField {
        public Func<bool> IsVisibleField { get; private set; }

        public SeparatorCommand() {
            IsVisibleField = () => true;
        }

        public void IsVisible(Func<bool> condition) {
            IsVisibleField = condition;
        }
    }
}
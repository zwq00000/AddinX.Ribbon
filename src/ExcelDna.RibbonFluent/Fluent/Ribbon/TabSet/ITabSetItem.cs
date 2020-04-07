using System;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Ribbon {
    public interface ITabSetItem {
        void Tabs(Action<ITabs> value);
    }
}
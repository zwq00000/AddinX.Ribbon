using System;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Ribbon {
    public interface IContextualTabs {
        IContextualTabs AddTabSet(Action<ITabSetId> value);
    }
}
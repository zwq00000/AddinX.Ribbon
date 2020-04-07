using System;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Ribbon {
    public interface IRibbon {
        IRibbon StartFromStrach(bool value);

        IRibbon Tabs(Action<ITabs> value);

        IRibbon ContextualTabs(Action<IContextualTabs> value);
    }
}
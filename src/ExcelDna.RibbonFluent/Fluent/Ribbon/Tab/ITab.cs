using System;
using ExcelDna.Fluent.Control;
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent.Ribbon {
    public interface ITab : IRibbonId<ITab>, IRibbonKeytip<ITab>
        //ITabItems, 
    {
        ITab Groups(Action<IGroups> value);
    }
}
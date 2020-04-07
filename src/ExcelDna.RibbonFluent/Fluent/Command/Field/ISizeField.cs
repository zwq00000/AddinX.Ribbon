using System;

namespace ExcelDna.Fluent.Command.Field {
    public interface ISizeField {
        Func<ControlSize> getSize { get; set; }
    }
}
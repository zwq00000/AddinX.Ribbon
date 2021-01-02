namespace ExcelDna.Fluent {
    public interface IRibbonBuilder {
        ICustomUI CustomUi { get; }

        string GetXmlString();
    }
}
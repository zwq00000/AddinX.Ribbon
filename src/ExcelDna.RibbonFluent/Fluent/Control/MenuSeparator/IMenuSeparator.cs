namespace ExcelDna.Fluent.Control {
    public interface IMenuSeparator : IRibbonIdQ<IMenuSeparator> {
        IMenuSeparator SetTitle(string title);
    }
}
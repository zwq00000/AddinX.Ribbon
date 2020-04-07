namespace ExcelDna.Fluent {
    /// <summary>
    /// 指定控件在 RibbonBox 上是垂直对齐还是水平对齐
    /// </summary>
    public enum BoxStyle {
        /// <summary>
        /// 控件左右相互对齐
        /// </summary>
        Horizontal = 0,

        /// <summary>
        /// 控件上下相互对齐。 如果一列中没有足够空间可显示控件，那么其余控件将在其他列中显示
        /// </summary>
        Vertical = 1,
    }
}
using ExcelDna.Fluent.Ribbon;

namespace ExcelDna.Fluent {
    /// <summary>
    /// 自定义UI 接口
    /// </summary>
    public interface ICustomUI {
        /// <summary>
        /// Ribbon Control
        /// </summary>
        IRibbon Ribbon { get; }

        /// <summary>
        /// Add user namespace
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="privateNamespace"></param>
        /// <returns></returns>
        ICustomUI AddNamespace(string letter, string privateNamespace);
    }
}
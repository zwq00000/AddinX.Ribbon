using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent {
    public interface IRibbonBuilder {
        ICustomUI CustomUi { get; }

        string GetXmlString();
    }

    /// <summary>
    /// Ribbon callback 注册器
    /// </summary>
    public interface ICallbackRegister {
        /// <summary>
        /// 注册命令
        /// </summary>
        /// <param name="elementId"></param>
        /// <param name="command"></param>
        void Add(IElementId elementId, ICommand command);

        /// <summary>
        /// 根据 ControlId 查找命令对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICommand Find(string id);
    }
}
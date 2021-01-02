using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ExcelDna.Fluent.Command;
using ExcelDna.Fluent.Internal;
using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using Image = System.Drawing.Image;

namespace ExcelDna.Fluent {
    [ComVisible(true)]
    public abstract partial class FluentRibbon : ExcelRibbon, IRibbonFluent {
        protected IRibbonUI Ribbon;

        private ICallbackRegister _callbackRegister;

        protected FluentRibbon() {
            _callbackRegister = new RibbonCommands();
        }

        public override void OnBeginShutdown(ref Array custom) {
            OnClosing();
            _callbackRegister = null;
            base.OnBeginShutdown(ref custom);
        }

        public override string GetCustomUI(string ribbonId) {
            OnOpening();
            var ribbonXml = GetRibbonXml();
            Debug.WriteLine(ribbonXml);
            return ribbonXml;
        }

        public virtual void OnLoad(IRibbonUI ribbon) {
            this.Ribbon = ribbon;
        }

        /// <summary>
        /// 响应 loadImage 事件,继承类需要实现该方法加载图像
        /// </summary>
        /// <param name="imageName"></param>
        /// <returns></returns>
        public virtual Image OnLoadImage(string imageName) {
            return null;
        }

        public string GetRibbonXml() {
            RibbonBuilder builder;
            if (ExcelDnaUtil.ExcelVersion >= 14.0) {
                builder = new RibbonBuilder(NamespaceCustomUI2010) {
                    CallbackRegister = _callbackRegister
                };
                CreateFluentRibbon(builder);
            }

            if (ExcelDnaUtil.ExcelVersion < 12.0) {
                throw new InvalidOperationException("Not expected to provide CustomUI string for Excel version < 12.0");
            } else {
                builder = new RibbonBuilder(NamespaceCustomUI2007) {
                    CallbackRegister = _callbackRegister
                };
                CreateFluentRibbon(builder);
            }

            return builder.GetXmlString();
        }

        public ICommand FindCallback(string id) {
            return _callbackRegister.Find(id);
        }

        /// <summary>
        /// 创建 Ribbon Xml
        /// </summary>
        /// <param name="builder"></param>
        protected abstract void CreateFluentRibbon(IRibbonBuilder builder);

        public virtual void OnClosing() {
        }

        public virtual void OnOpening() {
        }

        #region Implementation of IRibbonFluentCallback

        #endregion
    }
}
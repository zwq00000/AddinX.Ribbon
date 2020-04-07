using ExcelDna.Fluent.Control;

namespace AddinX.Fluent.Impl.Control {
    public class ButtonUnsize : Control<IButtonUnsize>, IButtonUnsize {
        public ButtonUnsize() : base("button") {
            NoImage();
        }

        protected override IButtonUnsize Interface => this;
    }
}
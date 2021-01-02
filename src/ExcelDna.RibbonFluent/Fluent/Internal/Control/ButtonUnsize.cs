using ExcelDna.Fluent.Control;

namespace ExcelDna.Fluent.Internal.Control {
    public class ButtonUnsize : Control<IButtonUnsize>, IButtonUnsize {
        public ButtonUnsize() : base("button") {
            NoImage();
        }

        protected override IButtonUnsize Interface => this;
    }
}
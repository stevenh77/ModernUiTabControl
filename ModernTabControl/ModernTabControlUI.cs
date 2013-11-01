using System.Windows;
using System.Windows.Controls;

namespace ModernTabControl
{
    public class ModernTabControlUI : TabControl
    {
        private ContentPresenter content;

        public ModernTabControlUI()
        {
            this.SelectionChanged += ModernTabControlUI_SelectionChanged;
        }
        
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            content = GetTemplateChild("ContentTop") as ContentPresenter;
        }

        void ModernTabControlUI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.content == null) return;

            // force content back to having negative offset
            VisualStateManager.GoToState(this, "Normal", true);

            // slide in content
            VisualStateManager.GoToState(this, "Transition", true);
        }
    }
}

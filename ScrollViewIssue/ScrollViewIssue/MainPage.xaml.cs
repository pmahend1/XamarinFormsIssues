using System.ComponentModel;
using Xamarin.Forms;

namespace ScrollViewIssue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class BasePage : ContentPage
    {
        public BasePage()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty BasePageContentProperty =
                    BindableProperty.Create(propertyName: nameof(PageContent),
                        returnType: typeof(View),
                        declaringType: typeof(BasePage),
                        defaultValue: null,
                        propertyChanged: ContentChanged);

        private static void ContentChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var _basePage = bindable as BasePage;
            var _newView = newValue as View;
            _basePage.pageContent.Content = _newView;
        }

        public View PageContent
        {
            get { return (View)GetValue(BasePageContentProperty); }
            set { SetValue(BasePageContentProperty, value); }
        }
    }
}

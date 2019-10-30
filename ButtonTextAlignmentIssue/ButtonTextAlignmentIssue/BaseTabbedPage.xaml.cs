
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonTextAlignmentIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseTabbedPage : TabbedPage
    {
        public BaseTabbedPage()
        {

            InitializeComponent();
            var page1 = new NavigationPage(new ContentPage() { Title = "Tab 1", Content = new Label { Text = "page 1" } }) { Title = "Tab1" };
            var page2 = new NavigationPage(new MainPage() { Title = "Tab 2" }) { Title = "Tab 2" };
            var page3 = new NavigationPage(new ContentPage() { Title = "Tab 3", Content = new Label { Text = "page 3" } }) { Title = "Tab 3" };
            var page4 = new NavigationPage(new MainPage() { Title = "Tab 4" }) { Title = "Tab 4" };
            var page5 = new NavigationPage(new ContentPage() { Title = "Tab 5", Content = new Label { Text = "page 5" } }) { Title = " Tab 5" };
            this.Children.Add(page1);
            this.Children.Add(page2); 
           
            this.Children.Add(page3);
            this.Children.Add(page4);

            this.Children.Add(page5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsControls.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UISwipeBackIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            this.Children.Add(new AnimationNavigationPage(new Page1()) { BarBackgroundColor = Color.Navy, Title = "Page1", BarTextColor = Color.White });
            this.Children.Add(new AnimationNavigationPage(new Page2()) { BarBackgroundColor = Color.Navy, Title = "Page2", BarTextColor = Color.White });
            this.Children.Add(new AnimationNavigationPage(new Page3()) { BarBackgroundColor = Color.Navy, Title = "Page3", BarTextColor = Color.White });
            this.Children.Add(new AnimationNavigationPage(new Page4()) { BarBackgroundColor = Color.Navy, Title = "Page4", BarTextColor = Color.White });

        }
    }
}

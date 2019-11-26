using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public class LocalPage : ContentPage
    {
        public LocalPage()
        {
            var navBarTemplate = (ControlTemplate)Application.Current.Resources["NavBarTemplate"];
            if (navBarTemplate != null)
            {
                var templatedView = new TemplatedView() { ControlTemplate = navBarTemplate };

                NavigationPage.SetTitleView(this, templatedView);
                NavigationPage.SetHasBackButton(this, false);
            }
            BackCommand = new Command(() =>
            {
                var navstackcount = Navigation.NavigationStack.Count;
                if (navstackcount > 1)
                {
                    Debug.WriteLine(String.Format("Current stack count {0}", navstackcount));
                    var currentPage = Navigation.NavigationStack[navstackcount - 1];
                    Device.BeginInvokeOnMainThread(async () => await Navigation.PopAsync());
                    
                }
            });

        }

        public static readonly BindableProperty BackCommandProperty =
          BindableProperty.Create(propertyName: nameof(BackCommand),
                                  returnType: typeof(Command),
                                  declaringType: typeof(LocalPage),
                                  defaultValue: null,
                                  defaultBindingMode: BindingMode.TwoWay, validateValue: null, propertyChanged: (bindable, oldValue, newValue) =>
                                  {
                                      (bindable as LocalPage).BackCommand = (Command)newValue;
                                  });
        public Command BackCommand
        {
            get { return (Command)GetValue(BackCommandProperty); }
            set { SetValue(BackCommandProperty, value); }
        }
    }
}


using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public partial class Page2 : LocalPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new ViewModel(this.Navigation);
        }
    }
}

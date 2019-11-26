using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public partial class Page3 : LocalPage
    {
        public Page3()
        {
            InitializeComponent();
            BindingContext = new ViewModel(this.Navigation);
        }
    }
}

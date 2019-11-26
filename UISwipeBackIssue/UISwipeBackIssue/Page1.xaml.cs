using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public partial class Page1 : LocalPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new ViewModel(Navigation);
        }
    }
}

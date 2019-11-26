using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public partial class Page4 : LocalPage
    {
        public Page4()
        {
            InitializeComponent();
            BindingContext = new ViewModel(this.Navigation);
        }
    }
}

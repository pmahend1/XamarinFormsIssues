using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace ButtonTextAlignmentIssue
{
    public class MainViewModel : MvxViewModel
    {

        private Color SelectedBackgroundColor => Color.Red;
        private Color UnselectedBackgroundColor => Color.White;
        private Color SelectedTextColor => Color.White;
        private Color UnselectedTextColor => Color.Red;

        public MainViewModel()
        {



            OnPrimarialClicked();
            PrimarialCommand = new Command(OnPrimarialClicked);
            Secondary_ButtonCommand = new Command(OnSecondary_ButtonClicked);
        }

        public ContentView ContentView { get; set; }

        public Command PrimarialCommand { get; set; }

        public Command Secondary_ButtonCommand { get; set; }

        public Color PrimarialBackgroundColor { get; set; }

        public Color PrimarialTextColor { get; set; }

        public Color SecondaryBackgroundColor { get; set; }

        public Color SecondaryTextColor { get; set; }

        public Color SecondaryBorderColor { get; set; }

        public Color PrimarialBorderColor { get; set; }

        //public string Count => Colors.Count <= 0 ? string.Empty : Colors.Count.ToString();
        //public string Image => "ShoppingPrimarial.png";

        //public ObservableCollection<Models.ViewColor> Colors { get; set; } = new ObservableCollection<Models.ViewColor>();

        private void OnPrimarialClicked()
        {
            ContentView = new ContentView() { Content = new Label() { Text = "Primarial" , TextColor= Color.Red} };
            RaisePropertyChanged(nameof(ContentView));

            SetPrimarialStyle(SelectedBackgroundColor, SelectedTextColor, SelectedBackgroundColor);
            SetSecondary_ButtonStyle(UnselectedBackgroundColor, UnselectedTextColor, UnselectedTextColor);
        }

        private void OnSecondary_ButtonClicked()
        {
            ContentView = new ContentView() { Content = new Label() { Text = "Secondary button", TextColor = Color.Red } };
            RaisePropertyChanged(nameof(ContentView));

            SetPrimarialStyle(UnselectedBackgroundColor, UnselectedTextColor, UnselectedTextColor);
            SetSecondary_ButtonStyle(SelectedBackgroundColor, SelectedTextColor, SelectedBackgroundColor);
        }

        private void SetPrimarialStyle(Color backgroundColor, Color textColor, Color bordercolor)
        {
            PrimarialBackgroundColor = backgroundColor;
            PrimarialTextColor = textColor;
            PrimarialBorderColor = bordercolor;

            RaisePropertyChanged(nameof(PrimarialBackgroundColor));
            RaisePropertyChanged(nameof(PrimarialTextColor));
            RaisePropertyChanged(nameof(PrimarialBorderColor));
        }

        private void SetSecondary_ButtonStyle(Color backgroundColor, Color textColor, Color bordercolor)
        {
            SecondaryBackgroundColor = backgroundColor;
            SecondaryTextColor = textColor;
            SecondaryBorderColor = bordercolor;

            RaisePropertyChanged(nameof(SecondaryBackgroundColor));
            RaisePropertyChanged(nameof(SecondaryTextColor));
            RaisePropertyChanged(nameof(SecondaryBorderColor));
        }

        ////public Command OrderCommand { get; set; }

        //public bool HasFavorites => Colors.Any();

        //private void FavoritesChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    SetColorsList();
        //    if (ContentView is Primarial)
        //    {
        //        OnPrimarialClicked();
        //    }
        //    else
        //    {
        //        OnSecondary ButtonClicked();
        //    }
        //}




    }

}
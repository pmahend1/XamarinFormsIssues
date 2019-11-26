using System;
using System.Diagnostics;
using System.Reflection;
using UIKit;
using UISwipeBackIssue.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(UISwipeBackIssue.LocalPage), typeof(LocalPageRenderer))]
namespace UISwipeBackIssue.iOS
{
    public class LocalPageRenderer : PageRenderer
    {

        private LocalPage _LocalPage;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                return;
            }

            if (e.NewElement != null)
            {
                _LocalPage = e.NewElement as LocalPage;


            }


        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            UIApplication.CheckForEventAndDelegateMismatches = false;
            if (NavigationController != null)
            {
                var iosVersion = Xamarin.Essentials.DeviceInfo.Version;
                Debug.WriteLine("Current ver {0}", iosVersion.ToString());

                var deviceType = Xamarin.Essentials.DeviceInfo.DeviceType;
                Debug.WriteLine("Current ver {0}", deviceType.ToString());

                var model = Xamarin.Essentials.DeviceInfo.Model;
                Debug.WriteLine("Current ver {0}", model);
                if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))
                {
                    try
                    {
                        if (NavigationController.InteractivePopGestureRecognizer is UIScreenEdgePanGestureRecognizer edgeReco)
                        {
                            if (!edgeReco.Enabled)
                            {
                                //NavigationController.SetNeedsUpdateOfScreenEdgesDeferringSystemGestures();
                                edgeReco.Enabled = true;
                                NavigationController.InteractivePopGestureRecognizer.Delegate = new NavDelegate();

                            }
                            else
                            {
                                //NavigationController.SetNeedsUpdateOfScreenEdgesDeferringSystemGestures();
                                NavigationController.InteractivePopGestureRecognizer.Delegate = new NavDelegate();

                            }
                        }

                        var popUpnav = NavigationController.InteractivePopGestureRecognizer;
                        Debug.WriteLine(popUpnav?.Name);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Exception at InteractivepopupgestureRecognizer" + ex.Message);
                    }

                }




            }
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }


        private class NavDelegate : UIGestureRecognizerDelegate
        {

            public override bool ShouldBeRequiredToFailBy(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
            {
                Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
                //return base.ShouldBeRequiredToFailBy(gestureRecognizer, otherGestureRecognizer);
                return true;
            }

            public override bool ShouldBegin(UIGestureRecognizer recognizer)
            {
                Debug.WriteLine(MethodBase.GetCurrentMethod().Name);

                //base.ShouldBegin(recognizer);
                return true;
            }

            public override bool ShouldReceivePress(UIGestureRecognizer gestureRecognizer, UIPress press)
            {
                Debug.WriteLine(MethodBase.GetCurrentMethod().Name);

                //base.ShouldReceivePress(gestureRecognizer, press);
                return true;
            }

            public override bool ShouldRecognizeSimultaneously(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
            {
                Debug.WriteLine(MethodBase.GetCurrentMethod().Name);

                //  base.ShouldRecognizeSimultaneously(gestureRecognizer, otherGestureRecognizer);
                return true;

            }

            public override bool ShouldRequireFailureOf(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
            {

                Debug.WriteLine(MethodBase.GetCurrentMethod().Name);

                //return base.ShouldRequireFailureOf(gestureRecognizer, otherGestureRecognizer);
                return false;
            }


        }

    }
}

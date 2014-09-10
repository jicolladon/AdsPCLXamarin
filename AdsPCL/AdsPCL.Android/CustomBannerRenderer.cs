using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Gms.Ads;
using Android.CustomRenders;
using AdsPCL;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(MyBanner), typeof(CustomBannerRenderer))]
namespace Android.CustomRenders
{
    public class CustomBannerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                AdView ad = new AdView(this.Context);
                ad.AdSize = AdSize.Banner;
                ad.AdUnitId = "Your key";
                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());
                this.SetNativeControl(ad);
            }
        }
    }
}

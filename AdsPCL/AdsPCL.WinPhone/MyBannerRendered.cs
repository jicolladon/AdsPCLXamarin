using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleAds;
using Xamarin.Forms.Platform.WinPhone;
using Xamarin.Forms;
using WinPhone.CustomRenders;
using AdsPCL;


[assembly: ExportRenderer(typeof(MyBanner), typeof(CustomBannerRenderer))]
namespace WinPhone.CustomRenders
{
    public class CustomBannerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                AdView bannerAd = new AdView
                {
                    Format = AdFormats.Banner,
                    AdUnitID = "Your key",
                };
                AdRequest adRequest = new AdRequest();
                bannerAd.LoadAd(adRequest);
                Children.Add(bannerAd);
            }

        }
    }
}

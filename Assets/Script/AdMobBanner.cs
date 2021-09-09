using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;

public class AdMobBanner : MonoBehaviour
{
    public BannerView bannerView;

    void Start()
    {
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }

    public void RequestBanner()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-1085463286951014/3884027589";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    public void BannerDelete()
    {
        bannerView.Destroy();
    }
}

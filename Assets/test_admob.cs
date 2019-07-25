﻿using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;

public class test_admob : MonoBehaviour {

    private BannerView bannerView;
    public void Start()
    {
#if UNITY_ANDROID
            string appId = "ca-app-pub-3940256099942544~3347511713";
#elif UNITY_IPHONE
        string appId = "ca-app-pub-9454451393863828~2171462141";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        Debug.Log("Init AD:"+appId);
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);

        Debug.Log("RequestBannder:"+adUnitId);
    }


    private void OnGUI()
    {
        if (GUILayout.Button("RequestBanner",GUILayout.Width(100),GUILayout.Height(100)))
        {
            RequestBanner();
        }
    }

}

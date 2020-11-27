﻿using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{

    public sealed class HiAnalyticsInstance : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static HiAnalyticsInstance NewInstance(AndroidJavaObject javaObject) => new HiAnalyticsInstance(javaObject);

        public HiAnalyticsInstance(AndroidJavaObject javaObject) : base(javaObject) { }
        public void SetAnalyticsEnabled(bool enabled)
        {
            Call("setAnalyticsEnabled", enabled);
        }
        public void SetAutoCollectionEnabled(bool isEnabled)
        {
            Call("setAutoCollectionEnabled", isEnabled);
        }

        public void SetUserId(String id)
        {
            Call("setUserId", id);
        }
        public void SetUserProfile(String name, String value)
        {
            Call("setUserProfile", name, value);
        }
        public void SetPushToken(String token)
        {
            Call("setPushToken", token);
        }
        public void SetMinActivitySessions(long milliseconds)
        {
            Call("setMinActivitySessions", milliseconds);
        }
        public void SetSessionDuration(long milliseconds)
        {
            Call("setSessionDuration", milliseconds);
        }
        public void SetCurrentActivity(String activityName, String activityClassOverride)
        {
            //AndroidContext activity, 
            Call("setCurrentActivity", activityName, activityClassOverride);
        }
        public void OnEvent(String eventId, Bundle androidBundle)
        {
            Call("onEvent", eventId, androidBundle);
        }
        public void ClearCachedData()
        {
            Call("clearCachedData");
        }
        public TaskHuaweiJavaObject GetAAID  => Call<TaskHuaweiJavaObject>("getAAID"); 
         
        public void RegHmsSvcEvent()
        {
            Call("regHmsSvcEvent");
        }
        public void UnRegHmsSvcEvent()
        {
            Call("unRegHmsSvcEvent");
        }
        public Map<String, String> GetUserProfiles(bool var1)
        {
            return Call<Map<String, String>>("getUserProfiles", var1); 
        }
        public void PageStart(String pageName, String pageClassOverride)
        {
            Call("pageStart", pageName, pageClassOverride);
        }
        public void PageEnd(String pageName)
        {
            Call("pageEnd", pageName);
        }



    }

}


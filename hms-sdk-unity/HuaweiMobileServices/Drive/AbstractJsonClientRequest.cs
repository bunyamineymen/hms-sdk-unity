﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public abstract class AbstractJsonClientRequest<T> : AbstractClientRequest<T>
    {
        [UnityEngine.Scripting.Preserve]
        public AbstractJsonClientRequest( AndroidJavaObject javaObject) : base(javaObject) { }

    }
}

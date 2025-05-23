//-----------------------------------------------------------------------
// <copyright file="HeadsetProviderFactory.cs" company="Google Inc.">
// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using UnityEngine;

/// @cond
namespace Gvr.Internal
{
    /// <summary>
    /// Factory that provides a concrete implementation of `IHeadsetProvider` for the current
    /// platform.
    /// </summary>
    //    static class HeadsetProviderFactory
    //    {
    //        /// <summary>
    //        /// Provides a concrete implementation of `IHeadsetProvider` appropriate for the current
    //        /// platform.
    //        /// <summary>
    //        /// <remarks>
    //        /// This method never returns null. In the worst case, it might return a dummy
    //        /// provider if the platform is not supported. For demo purposes the emulator controller
    //        /// is returned in the editor and in Unity Standalone (desktop) builds, for use inside the
    //        /// desktop player.
    //        /// </remarks>
    //        /// <returns>An implemented `IHeadsetProvider` appropriate for the platform.</returns>
    //        static internal IHeadsetProvider CreateProvider()
    //        {
    //            // Use emualtor in editor, GVR SDK support on Daydream 6DoF headsets, and a
    //            // dummy implementation otherwise.
    //#if UNITY_EDITOR
    //            return new EditorHeadsetProvider();
    //#elif UNITY_ANDROID
    //            // Use the GVR C API.
    //            return new AndroidNativeHeadsetProvider();
    //#else
    //            // Platform not supported.
    //            Debug.LogWarning("No GoogleVR 6DoF headset support on " +
    //                Application.platform + " platform.");
    //            return new DummyHeadsetProvider();
    //#endif  // UNITY_EDITOR || UNITY_ANDROID
    //        }
}

/// @endcond

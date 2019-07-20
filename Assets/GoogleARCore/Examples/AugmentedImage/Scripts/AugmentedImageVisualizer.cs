//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        public GameObject TestAsset;

        public GameObject TransformAsset;

        public GameObject DivergentAsset;

        public GameObject ReverseAsset;

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                TestAsset.SetActive(false);
                TransformAsset.SetActive(false);
                DivergentAsset.SetActive(false);
                ReverseAsset.SetActive(false);
                return;
            }

            if (Image.Name == "Earth")
            {
                //float halfWidth = Image.ExtentX / 2;
                //float halfHeight = Image.ExtentZ / 2;
                TestAsset.transform.localPosition =
                    (0 * Vector3.left) + (0 * Vector3.back); //(halfWidth * Vector3.left) + (halfHeight * Vector3.back);
                TestAsset.SetActive(true);
            }

            if (Image.Name == "Transform")
            {
                TransformAsset.transform.localPosition =
                    (0 * Vector3.left) + (0 * Vector3.back);
                TransformAsset.SetActive(true);
            }

            if (Image.Name == "Divergent")
            {
                DivergentAsset.transform.localPosition =
                    (0 * Vector3.left) + (0 * Vector3.back);
                DivergentAsset.SetActive(true);
            }

            if (Image.Name == "Reverse")
            {
                ReverseAsset.transform.localPosition =
                    (0 * Vector3.left) + (0 * Vector3.back);
                ReverseAsset.SetActive(true);
            }


            //TestAsset.SetActive(true);
        }
    }
}

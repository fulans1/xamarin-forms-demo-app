﻿/*                                                         
               Copyright (c) 2019 Developer Express Inc.                
{*******************************************************************}   
{                                                                   }   
{       Developer Express Mobile UI for Xamarin.Forms               }   
{                                                                   }   
{                                                                   }   
{       Copyright (c) 2019 Developer Express Inc.                   }   
{       ALL RIGHTS RESERVED                                         }   
{                                                                   }   
{   The entire contents of this file is protected by U.S. and       }   
{   International Copyright Laws. Unauthorized reproduction,        }   
{   reverse-engineering, and distribution of all or any portion of  }   
{   the code contained in this file is strictly prohibited and may  }   
{   result in severe civil and criminal penalties and will be       }   
{   prosecuted to the maximum extent possible under the law.        }   
{                                                                   }   
{   RESTRICTIONS                                                    }   
{                                                                   }   
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }   
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }   
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }   
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING         }   
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }   
{                                                                   }   
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }   
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }   
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }   
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }   
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }   
{                                                                   }   
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }   
{   ADDITIONAL RESTRICTIONS.                                        }   
{                                                                   }   
{*******************************************************************}   
*/
using System;
using System.Collections.Generic;
using DemoCenter.Forms.Data;
using Xamarin.Forms;

namespace DemoCenter.Forms.ViewModels {
    public class MultipleAxesViewModel : ContentPage {
        readonly TunedEngineData engineData;
        readonly Color[] palette = PaletteLoader.LoadPalette("#FF327bb7", "#FFe33e3e", "#FF81c1f6", "#FFff9090", "#FFff6363", "#FF42a5f6", "#4CA184AD", "#4C42a5f6", "#00000000");
        readonly IList<String> names;

        public IList<NumericData> NEPower => engineData.NEPower;
        public IList<NumericData> NETorque => engineData.NETorque;
        public IList<NumericData> MKRPower => engineData.MKRPower;
        public IList<NumericData> MKRTorque => engineData.MKRTorque;
        public IList<NumericData> NEFuelRate => engineData.NEFuelRate;
        public IList<NumericData> MKRFuelRate => engineData.MKRFuelRate;
        public IList<String> Names => names;
        public Color[] Palette => palette;

        public MultipleAxesViewModel() {
            engineData = new TunedEngineData();
            names = new List<String>() { "NEPower", "NETorque", "NEFuelRate", "MKRPower", "MKRTorque", "MKRFuelRate" };
        }
    }
}

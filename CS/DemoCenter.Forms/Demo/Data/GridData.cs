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
using DemoCenter.Forms.Models;
using DemoCenter.Forms.Views;

namespace DemoCenter.Forms.Data {
    public class GridData : IDemoData {
        List<DemoItem> demoItems;

        public GridData() {
            demoItems = new List<DemoItem>() {
                new DemoItem() {
                    Title = "First Look",
                    Description="Demonstrates the DataGridView’s basic features.",
                    Module = typeof(FirstLookView),
                    Icon = "GridList.FirstLook.svg"},
                new DemoItem() {
                    Title = "Row Auto Height",
                    Description="Shows how the grid can automatically adjust row height to display the entire content of cells.",
                    Module = typeof(RowAutoHeightView),
                    Icon = "GridList.RowAutoHeight.svg"},
                new DemoItem() {
                    Title = "Real-Time Data",
                    Description="Demonstrates a grid view that automatically displays new data when the data source changes.",
                    Module = typeof(RealTimeDataView),
                    Icon = "GridList.RealTimeData.svg"},
                new DemoItem() {
                    Title = "Editing",
                    Description="Demonstrates the grid’s inplace data editors.",
                    Module = typeof(EditingView),
                    Icon = "GridList.Editing.svg"},
                new DemoItem() {
                    Title = "Swipe"+Environment.NewLine+"Actions",
                    ControlsPageTitle = "Swipe Actions",
                    Description="Illustrates the UI that is extended with extra buttons when you swipe a data row.",
                    Module = typeof(SwipeButtonsView),
                    Icon = "GridList.SwipeButtons.svg"},
                new DemoItem() {
                    Title = "Pull To Refresh",
                    Description="Shows how to update the grid’s content with the pull-down gesture.",
                    Module = typeof(PullToRefreshView),
                    Icon = "GridList.PullToRefresh.svg"},
                new DemoItem() {
                    Title = "Infinite"+Environment.NewLine+"Data Source",
                    ControlsPageTitle = "Infinite Data Source",
                    Description="Shows how the grid requests new data when users scroll the grid to the end.",
                    Module = typeof(LoadMoreView),
                    Icon = "GridList.InfiniteDataSource.svg"},
                new DemoItem() {
                    Title = "Grouping",
                    Description="Illustrates how the grid groups data against a column and calculates data summaries.",
                    Module = typeof(GroupingView),
                    Icon = "GridList.Grouping.svg",
                    ShowItemUnderline = false}
            };
        }
        public List<DemoItem> DemoItems => demoItems;
        public string Title { get { return "DataGridView"; } }
    }
}
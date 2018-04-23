using DevExpress.Core;
using DevExpress.UI.Xaml.Layout;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Windows.System.Threading;
using App1.ServiceReference1;

namespace App1.View {
    /// <summary>
    /// A page that displays an overview of a single group, including a preview of the items
    /// within the group.
    /// </summary>
    public sealed partial class MainPage: DXPage {
        Service1Client Service1 = new Service1Client();

        public AsyncCollection<Item> Items { get; set; }
        public MainPage() {
            this.InitializeComponent();

            Items = new AsyncCollection<Item>(
                async () => {
                    return await Service1.CountAsync();
                },
                async (int skipCount, int takeCount) => {
                    return await Service1.GetDataAsync(skipCount, takeCount);
                });
            grid.ItemsSource = Items;
        }
    }
}
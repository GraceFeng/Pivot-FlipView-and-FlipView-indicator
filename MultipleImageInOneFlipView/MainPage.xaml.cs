using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MultipleImageInOneFlipView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<MyFlipViewItem> items;
        private ObservableCollection<MyFlipViewItem> itemsPC;

        public MainPage()
        {
            this.InitializeComponent();
            items = new ObservableCollection<MyFlipViewItem>();
            itemsPC = new ObservableCollection<MyFlipViewItem>();
            flipView.ItemsSource = items;
            indicator.ItemsSource = items;
            flipViewPC.ItemsSource = itemsPC;
            indicatorPC.ItemsSource = itemsPC;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            items.Clear();
            items.Add(new MyFlipViewItem { image1 = "Assets/11.png", image2 = "Assets/22.png", image3 = "Assets/33.png" });
            items.Add(new MyFlipViewItem { image1 = "Assets/44.png", image2 = "Assets/66.png", image3 = "Assets/55.png" });

            itemsPC.Clear();
            itemsPC.Add(new MyFlipViewItem { imagepc = "Assets/111.png" });
            itemsPC.Add(new MyFlipViewItem { imagepc = "Assets/222.png" });
            itemsPC.Add(new MyFlipViewItem { imagepc = "Assets/333.png" });
            itemsPC.Add(new MyFlipViewItem { imagepc = "Assets/444.png" });
            itemsPC.Add(new MyFlipViewItem { imagepc = "Assets/555.png" });
        }
    }

    public class MyFlipViewItem
    {
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }

        public string imagepc { get; set; }
    }
}
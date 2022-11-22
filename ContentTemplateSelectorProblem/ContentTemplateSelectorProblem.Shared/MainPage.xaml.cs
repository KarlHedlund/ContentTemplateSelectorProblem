using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;


namespace ContentTemplateSelectorProblem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var contentDialog = new CustomDialog() { XamlRoot = this.XamlRoot};
            var result = await contentDialog.ShowAsync();
        }
    }
}

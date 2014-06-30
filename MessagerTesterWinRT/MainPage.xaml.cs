using MessagerTesterNS;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MessagerTesterWinRT
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		private void OnPageLoaded( object sender, RoutedEventArgs e )
		{
			new MessagerTester();
		}
    }
}
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MessagerTesterWinRT
{
	sealed partial class App: Application
	{
		public App()
		{
			this.InitializeComponent();
			this.Suspending += OnSuspending;
		}

		protected override void OnLaunched( LaunchActivatedEventArgs e )
		{
#if DEBUG
			if( System.Diagnostics.Debugger.IsAttached )
			{
				this.DebugSettings.EnableFrameRateCounter = true;
			}
#endif

			var rootFrame = Window.Current.Content as Frame;
			if( rootFrame == null )
			{
				rootFrame = new Frame();
				rootFrame.Language = Windows.Globalization.ApplicationLanguages.Languages[0];
				rootFrame.NavigationFailed += OnNavigationFailed;

				Window.Current.Content = rootFrame;
			}

			if( rootFrame.Content == null )
			{
				rootFrame.Navigate( typeof( MainPage ), e.Arguments );
			}
			Window.Current.Activate();
		}

		void OnNavigationFailed( object sender, NavigationFailedEventArgs e )
		{
			throw new Exception( "Failed to load Page " + e.SourcePageType.FullName );
		}

		private void OnSuspending( object sender, SuspendingEventArgs e )
		{
			var deferral = e.SuspendingOperation.GetDeferral();
			deferral.Complete();
		}
	}
}

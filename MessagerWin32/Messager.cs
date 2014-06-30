using System;
#if WINDOWS_APP
using Windows.UI.Popups;
#endif

namespace MessagerNS
{
	public static class Messager
	{
		public static void Send( string data )
		{
#if WINDOWS_CLASSIC
			Console.WriteLine( data );
#elif WINDOWS_APP	
			var md = new MessageDialog( data );
			md.ShowAsync();
#else
			throw new NotImplementedException();
#endif
		}
	}
}
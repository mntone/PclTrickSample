using MessagerNS;

namespace MessagerTesterNS
{
    public sealed class MessagerTester
    {
		public MessagerTester()
		{
			Messager.Send( "send!!!" );
		}
    }
}

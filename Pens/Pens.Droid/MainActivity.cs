
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using s = Pens.Droid.CommonClass.SharedMethods;
namespace Pens.Droid
{
    [Activity (Label = "Pens.Droid", Icon = "@drawable/icon",ConfigurationChanges =Android.Content.PM.ConfigChanges.Orientation)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
            s.activity = this;
		
		}
	}
}



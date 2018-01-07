using Android.App;
using Android.OS;
using System.Threading.Tasks;

namespace Pens.Droid
{
    [Activity(Label = "SpashActivity" , MainLauncher =true)]
    public class SpashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Task task = new Task(PerformTask);
        }

      async private void PerformTask()
        {
          await Task.Delay(3000);
            StartActivity(typeof(MainActivity));
        }
    }
}
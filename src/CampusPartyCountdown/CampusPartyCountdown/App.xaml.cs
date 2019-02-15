using CampusPartyCountdown.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CampusPartyCountdown
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new MyCampusPartyCountdownView());
        }

        protected override void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=09ca5754-3daf-491a-ab33-0ffb5e755e45;" +
                            "ios={Your iOS App secret here}",
                            typeof(Analytics), typeof(Crashes));
        }
    }
}

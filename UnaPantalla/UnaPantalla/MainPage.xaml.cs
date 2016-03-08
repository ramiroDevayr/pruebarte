using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnaPantalla
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void IrAWeb(object sender, EventArgs e)
        {
            Uri u = new Uri("http://www.google.com");
            Xamarin.Forms.Device.OpenUri(u);
        }

        async void EnviarMail(object sender, EventArgs e)
        {
            /*var aamail = new Uri("mailto:?to=tickets@msiccdev.uservoice.com&subject=this is the Subject&body=this is the Body");
            await Launcher.LaunchUriAsync(mail);*/
            String a = "a";
            var email = DependencyService.Get<IEmail>();
            if (email != null)
                email.EnviarEmail(a,a,a,a);
        }
    }
}
 
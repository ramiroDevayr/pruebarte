using System;
using System.Collections.Generic;
using System.Text;
using UnaPantalla.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(EnviarMail))]

namespace UnaPantalla.iOS
{
    public class EnviarMail: IEmail
    {

        public void EnviarEmail(string manda, string recibe, string asunto, string cuerpo)
        {
            throw new NotImplementedException();
        }
    }
}

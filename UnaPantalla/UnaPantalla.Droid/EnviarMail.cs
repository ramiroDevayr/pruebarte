using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using UnaPantalla.Droid;
using Xamarin.Forms;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

[assembly: Dependency(typeof(EnviarMail))]

namespace UnaPantalla.Droid
{
    public class EnviarMail: IEmail
    {
            


            public void EnviarEmail(string manda, string recibe, string asunto, string cuerpo)
            {
                var message = new MimeMessage();
                //message.From.Add(new MailboxAddress("Info Devayr", "info@devayr.com"));
                message.From.Add(new MailboxAddress("Ramiro Sala", "ramiro.sala85@gmail.com"));
                message.To.Add(new MailboxAddress("Ramiro Sala", "ramiro.sala85@gmail.com"));
                message.Subject = "So marica bo?";

                message.Body = new TextPart("plain")
                {
                    Text = @"Hola, so marica bo?"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);

                    // Note: since we don't have an OAuth2 token, disable
                    // the XOAUTH2 authentication mechanism.
                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    // Note: only needed if the SMTP server requires authentication
                    //client.Authenticate("info@devayr.com", "ManagerZone2015");
                    client.Authenticate("ramiro.sala85@gmail.com", "RojoVerde");

                    client.Send(message);
                    client.Disconnect(true);
                }
                
                
                /*Intent i = new Intent(Android.Content.Intent.ActionSend);
                i.PutExtra(Android.Content.Intent.ExtraEmail, recibe);
                i.PutExtra(Android.Content.Intent.ExtraSubject, "Hello Email");
                i.PutExtra(Android.Content.Intent.ExtraText, "Hello from Xamarin.Android!");
                i.SetType("message/rfc822");

                //StartActivity(i);*/
                
            }
    }
}
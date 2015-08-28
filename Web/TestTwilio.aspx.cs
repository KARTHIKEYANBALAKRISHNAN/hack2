using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;
using ActiveUp.Net.Mail;
using PT.MailIntegration.IMAP;
namespace Web
{
    public partial class TestTwilio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                                   
        }
        
        public string SendSMS()
        {
            //var call = twilio.InitiateOutboundCall("+919962971796", "+1919962971796", "http://example.com/handleCall");
            string AccountSid = "AC5892a41ecc8b6c2707a8ce5ca2efde8c";
            string AuthToken = "34c82e61dcfc0f6fb14f5b8a61190e87";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage("+919962071729", "+919962979196", "Twilio");
            return message.Sid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailRepository rep = new MailRepository("imap.gmail.com", 993, true, @TextBox1.Text, TextBox2.Text);
            foreach (ActiveUp.Net.Mail.Message email in rep.GetUnreadMails("Inbox"))
            {
                string from = email.From.ToString();
                string subj = email.Subject;
                emails.InnerText = from + subj;
                SendSMS();
             }

        }//SendSMS
    }
}
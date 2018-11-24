using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PointsUI.Classes
{
    public class SMS
    {

        public static bool SendSms(string userName, string pass, string senderId,string phoneNumber, string message)
        {
            string url = string.Format("http://bulksms.mysmsmantra.com:8080/WebSMS/SMSAPI.jsp?username={0}&password={1}&sendername={2}&mobileno={3}&message={4}",userName,pass,senderId,phoneNumber,message);
            
            WebRequest w = WebRequest.Create(url);
            try
            {
                WebResponse r = w.GetResponse();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return true;           
        }

    }
}

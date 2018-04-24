using PushMessage;
using System;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace PushMessage
{
    public class PushMessageClient
    {
        /// <summary>
        /// Send a message through the tool define in Settings.cs
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool PushMessage(string title, string message)
        {
            var method = typeof(PushMessageClient).GetMethod(Settings.PushMessageMethod);
            var instance = new PushMessageClient();

            Func<object, MethodInfo, string, string, bool> func =
                (obj, m, arg1, arg2) => (bool)m.Invoke(obj, new object[] { arg1, arg2 });

            return func(instance, method, title, message);
        }

        /// <summary>
        /// Send a message through Pushover
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool PushThroughPushover(string title, string message)
        {
            string appKey = Settings.PushoverAppKey;
            string userGroupKey = Settings.PushoverUserGroupKey;

            Pushover pclient = new Pushover(appKey);
            PushResponse response = pclient.Push(title, message, userGroupKey);

            return response.Errors == null;
        }

        /// <summary>
        /// Send a message through Pushbullet
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool PushThroughPushbullet(string title, string message)
        {
            // Push a note to all devices.
            string apiKey = Settings.PushbulletApiKey;
            string type = "note";
            byte[] data = Encoding.ASCII.GetBytes(string.Format("{{ \"type\": \"{0}\", \"title\": \"{1}\", \"body\": \"{2}\" }}", type, title, message));

            var request = System.Net.WebRequest.Create("https://api.pushbullet.com/v2/pushes") as System.Net.HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Credentials = new System.Net.NetworkCredential(apiKey, "");

            request.ContentLength = data.Length;
            string responseJson = null;

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();
            }

            using (var response = request.GetResponse() as System.Net.HttpWebResponse)
            {
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseJson = reader.ReadToEnd();
                }
            }

            return true;
        }
    }
}

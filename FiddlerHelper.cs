using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Fiddler;
namespace Grasscutter_Client
{
    internal class FiddlerHelper
    {
        private static X509Certificate2 oRootCert;
        private static string separator = "----------------------------------------";
        public static void installcert()
        {
            
            if (null == CertMaker.GetRootCertificate())
            {
                //创建伪造证书
                CertMaker.createRootCert();

                //重新获取
                oRootCert = CertMaker.GetRootCertificate();

                //打开本地证书库
                X509Store certStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                certStore.Open(OpenFlags.ReadWrite);
                try
                {
                    //将伪造的证书加入到本地的证书库
                    certStore.Add(oRootCert);
                }
                finally
                {
                    certStore.Close();
                }
            }
            else
            {
                //以前伪造过证书，并且本地证书库中保存过伪造的证书
                oRootCert = CertMaker.GetRootCertificate();
            }
           
        }

        private static void OnBeforeRequest(Session oS)
        {
            if (oS.host.EndsWith(".yuanshen.com") || oS.host.EndsWith(".hoyoverse.com") || oS.host.EndsWith(".mihoyo.com"))
            {
                oS.host =Main.GAME_IP + ":" + Main.GAME_PORT;
            }
            if (oS.uriContains("http://uspider.yuanshen.com:8888/log"))
            {
                oS.oRequest.FailSession(200, "Blocked", "haha");
            }
        }

        public static void start()
        {
            if (!FiddlerApplication.IsStarted())
            {
                //FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
                FiddlerApplication.BeforeRequest += OnBeforeRequest;
                FiddlerApplication.oDefaultClientCertificate = oRootCert;
                CONFIG.IgnoreServerCertErrors = true;
                FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
                FiddlerApplication.Startup(8181,true,true,true);
            }
            else
            {
                Console.WriteLine("proxy is running");
            }
        }

        private static void FiddlerApplication_AfterSessionComplete(Session oSession)
        {
            if (oSession.RequestMethod == "CONNECT")
            {
                return;
            }
            if (oSession == null || oSession.oRequest == null || oSession.oRequest.headers == null)
            {
                return;
            }
            string headers = oSession.oRequest.headers.ToString();
            string body = Encoding.UTF8.GetString(oSession.RequestBody);
            string firstline = oSession.RequestMethod + " " + oSession.fullUrl + " " + oSession.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            if (at < 0)
                return;
            string output = firstline + Environment.NewLine + headers.Substring(at + 1);
            if (body != null)
            {
                output += body + Environment.NewLine;
            }
            output += separator + Environment.NewLine;
           
            if (oSession.host == Main.GAME_IP + ":" + Main.GAME_PORT)
            {
                Console.WriteLine(output);
            }
            
        }

        public static void stop()
        {
           
            if (FiddlerApplication.oProxy!=null)    
            {
                if (FiddlerApplication.oProxy.IsAttached)
                {
                    FiddlerApplication.oProxy.Detach();
                }
            }
            if (FiddlerApplication.IsStarted())
            {
                FiddlerApplication.Shutdown();
            }
        }
    }
}

using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DepartmentDal
{
    public class Utilities
    {
        public static string WebApi = "http://192.168.43.61:45455";
        //public static string WebApi = "https://localhost:44358";
       public static void NEVER_EAT_POISON_Disable_CertificateValidation()
       {
           ServicePointManager.ServerCertificateValidationCallback =
               delegate (
                   object s,
                   X509Certificate certificate,
                   X509Chain chain,
                   SslPolicyErrors sslPolicyErrors
               ) {
                   return true;
               };
       }
    }
}

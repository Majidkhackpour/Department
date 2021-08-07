using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DepartmentDal
{
    public class Utilities
    {
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

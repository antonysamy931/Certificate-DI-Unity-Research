using System;
using System.Security.Cryptography.X509Certificates;
namespace ReadCertificate
{
    class Program
    {
        static void Main(string[] args)
        {
            var cert = CertificateUtil.GetCertificateByThumbprint(StoreName.My, StoreLocation.LocalMachine, "‎0a367821995855285c9fe8a298bfcbe70c8ae76f");
            cert = CertificateUtil.GetCertificateBySubject(StoreName.My, StoreLocation.LocalMachine, "‎CN=TestReadCertificate");
            cert = CertificateUtil.GetCertificateBySubjectName(StoreName.My, StoreLocation.LocalMachine, "‎TestReadCertificate");
            cert = CertificateUtil.GetCertificateBySerialNumber(StoreName.My, StoreLocation.LocalMachine, "‎‎f448b317ef25ec9249afc121e362a89c");
            Console.Read();
        }
    }
}

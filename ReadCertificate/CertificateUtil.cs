using System;
using System.Security.Cryptography.X509Certificates;

namespace ReadCertificate
{
    public class CertificateUtil
    {
        public static X509Certificate2 GetCertificateByThumbprint(StoreName name, StoreLocation location, string thumbprint)
        {
            X509Certificate2 result = null;
            X509Store store = new X509Store(name, location);
            X509Certificate2Collection certificates = null;
            store.Open(OpenFlags.ReadOnly);
            try
            {
                certificates = store.Certificates;
                foreach (var c in certificates)
                {
                    if (string.Equals(c.Thumbprint, thumbprint, StringComparison.InvariantCultureIgnoreCase))
                    {
                        result = c;
                        break;
                    }
                }

                if (result == null)
                {
                    throw new ApplicationException(string.Format("No certificate was found for thumbprint {0}", thumbprint));
                }
            }
            finally
            {
                if (certificates != null)
                {
                    for (var i = 0; i < certificates.Count; i++)
                    {
                        var cert = certificates[i];
                        if (result == null || (result != null && !string.Equals(cert.Thumbprint, result.Thumbprint)))
                        {
                            cert.Reset();
                        }
                    }
                }
                store.Close();
            }
            return result;
        }

        public static X509Certificate2 GetCertificateBySubject(StoreName name, StoreLocation location, string subject)
        {
            X509Certificate2 result = null;
            X509Certificate2Collection certificates = null;
            X509Store store = new X509Store(name, location);
            store.Open(OpenFlags.ReadOnly);
            try
            {
                certificates = store.Certificates;
                foreach (var cert in certificates)
                {
                    if (string.Equals(cert.Subject, subject, StringComparison.InvariantCultureIgnoreCase))
                    {
                        result = cert;
                        break;
                    }
                }

                if (result == null)
                {
                    throw new ApplicationException(string.Format("No certificate was found for subject {0}", subject));
                }
            }
            finally
            {
                store.Close();
            }
            return result;
        }

        public static X509Certificate2 GetCertificateBySubjectName(StoreName name, StoreLocation location, string subjectname)
        {
            X509Certificate2 result = null;
            X509Certificate2Collection certificates = null;
            X509Store store = new X509Store(name, location);
            store.Open(OpenFlags.ReadOnly);
            try
            {
                certificates = store.Certificates;
                foreach (var cert in certificates)
                {
                    if (string.Equals(cert.SubjectName.Name.Substring(3), subjectname, StringComparison.InvariantCultureIgnoreCase))
                    {
                        result = cert;
                        break;
                    }
                }

                if (result == null)
                {
                    throw new ApplicationException(string.Format("No certificate was found for subject name {0}", subjectname));
                }
            }
            finally
            {
                store.Close();
            }
            return result;
        }

        public static X509Certificate2 GetCertificateBySerialNumber(StoreName name, StoreLocation location, string serialnumber)
        {
            X509Certificate2 result = null;
            X509Certificate2Collection certificates = null;
            X509Store store = new X509Store(name, location);
            store.Open(OpenFlags.ReadOnly);
            try
            {
                certificates = store.Certificates;
                foreach (var cert in certificates)
                {
                    if (string.Equals(cert.SerialNumber, serialnumber, StringComparison.InvariantCultureIgnoreCase))
                    {
                        result = cert;
                        break;
                    }
                }

                if (result == null)
                {
                    throw new ApplicationException(string.Format("No certificate was found for subject {0}", serialnumber));
                }
            }
            finally
            {
                store.Close();
            }
            return result;
        }
    }
}

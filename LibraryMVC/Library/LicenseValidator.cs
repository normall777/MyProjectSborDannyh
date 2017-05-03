using LibraryModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Library
{
    class LicenseValidator
    {
        public static bool CheckIfLicenseValid()
        {
            var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var files = Directory.GetFiles(mydocs, "*.liblicense");
            foreach (var file in files)
            {
                try
                {
                    if(TryLoadLicense(file))
                        break;
                }
                catch
                {

                }
            }
            return HasLicense;
        }
        public static bool CanWrite
        {
            get
            { return EnablesdFeatures.Contains(LicenseFeatures.Write); }
        }
        public static bool CanRead
        {
            get
            { return EnablesdFeatures.Contains(LicenseFeatures.Read); }
        }
        public static string UserMessage { get; set; }

        private static bool TryLoadLicense(string fileName)
        {
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

            rsaKey.FromXmlString(Library.Properties.Resources.PublicKey);

            // Create a new XML document.
            XmlDocument xmlDoc = new XmlDocument();

            // Load an XML file into the XmlDocument object.
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(fileName);

            // Verify the signature of the signed XML.
            bool result = VerifyXml(xmlDoc, rsaKey);
            if (!result)
            {
                UserMessage = "Файл лицензии поврежден";
                return false;
            }
            HasLicense = true;
            LicenseDto dto;
            using (var fileStream = File.OpenRead(fileName))
            {
                dto = (LicenseDto)new XmlSerializer(typeof(LicenseDto)).Deserialize(fileStream);
            }
            if (dto.ValidTo.HasValue && dto.ValidTo.Value < DateTime.Now)
            {
                UserMessage = "Лицензия истекла";
                HasLicense = false;
                return false;
            }

            if (dto.ValidFrom.HasValue && dto.ValidFrom.Value > DateTime.Now)
            {
                UserMessage = "Лицензионный период еще не начался";
                HasLicense = false;
                return false;
            }

            ToWhom = dto.ToWhom;
            ValidTo = dto.ValidTo;
            ValidFrom = dto.ValidFrom;
            if (dto.Features != null)
                foreach (var f in dto.Features)
                {
                    EnablesdFeatures.Add(f);
                }

            return true;
        }

        public static List<LicenseFeatures> EnablesdFeatures { get; set; } = new List<LicenseFeatures>();
        public static DateTime? ValidFrom { get; set; }
        public static DateTime? ValidTo { get; set; }
        public static string ToWhom { get; set; }
        public static bool HasLicense { get; set; }

        // Verify the signature of an XML file against an asymmetric
        // algorithm and return the result.
        public static Boolean VerifyXml(XmlDocument Doc, RSA Key)
        {
            // Check arguments.
            if (Doc == null)
                throw new ArgumentException("Doc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(Doc);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = Doc.GetElementsByTagName("Signature");

            // Throw an exception if no signature was found.
            if (nodeList.Count <= 0)
            {
                throw new CryptographicException("Verification failed: No Signature was found in the document.");
            }

            // This example only supports one signature for
            // the entire XML document. Throw an exception
            // if more than one signature was found.
            if (nodeList.Count >= 2)
            {
                throw new CryptographicException("Verification failed: More that one signature was found for the document.");
            }

            // Load the first <signature> node.
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(Key);
        }

    }
}

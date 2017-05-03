using LibraryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography.Xml;

namespace LibraryLicense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private static void GenerateNewKeyPair()
        {
            string withSecret;
            string woSecret;
            using (var rsaCsp = new RSACryptoServiceProvider())
            {
                withSecret = rsaCsp.ToXmlString(true);
                woSecret = rsaCsp.ToXmlString(false);
            }

            File.WriteAllText("private.xml", withSecret);
            File.WriteAllText("public.xml", woSecret);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.liblicense|*.liblicense" };
            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;


            var license = new LicenseDto
            {
                Features = new List<LicenseFeatures>(),
                ToWhom = textBox1.Text,
                ValidFrom = dateTimePicker1.Value,
                ValidTo = dateTimePicker2.Value
            };
            if (checkBox1.Checked)
                license.Features.Add(LicenseFeatures.Read);
            if (checkBox2.Checked)
                license.Features.Add(LicenseFeatures.Write);

            CreateLicenseFile(license, sfd.FileName);
        }

        public void CreateLicenseFile(LicenseDto dto, string fileName)
        {
            var ms = new MemoryStream();
            new XmlSerializer(typeof(LicenseDto)).Serialize(ms, dto);

            // Create a new CspParameters object to specify
            // a key container.

            // Create a new RSA signing key and save it in the container.
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
            rsaKey.FromXmlString(LibraryLicense.Properties.Resources.PrivateKey);

            // Create a new XML document.
            XmlDocument xmlDoc = new XmlDocument();

            // Load an XML file into the XmlDocument object.
            xmlDoc.PreserveWhitespace = true;
            ms.Seek(0, SeekOrigin.Begin);
            xmlDoc.Load(ms);

            // Sign the XML document.
            SignXml(xmlDoc, rsaKey);
            // Save the document.
            xmlDoc.Save(fileName);

        }
        public static void SignXml(XmlDocument xmlDoc, RSA Key)
        {
            // Check arguments.
            if (xmlDoc == null)
                throw new ArgumentException("xmlDoc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = Key;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

        }
    }
}

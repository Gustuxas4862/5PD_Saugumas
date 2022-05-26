using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace ReceiverServer
{
    public partial class ServerPanel : Form
    {
        private string rsaKeys = "<RSAKeyValue><Modulus>vU3Yfu1Z4nFknj9daoDmh+I0CzR+aLnTjUSejQyNJ0IgMb59x4mVe17C6U+bl4Cry7gXAk3LEmmE/BRxjlF8HKlXixoBWak1dpmr89Ye7iaD2UWwl5Dmn07Q9s27NGdywy0BsD1vDcFSgno3LUbVznkw/0hypbnOPxWKlBCao2c=</Modulus><Exponent>AQAB</Exponent><P>6veL+pbUjOr0PAiFcvBRwNlTz/+8T1iLHqkCggRPDSsTg25ybSqDa98mP5NQj9LHSYCECjOGZkiN4NoxgPPDxw==</P><Q>zj/l0Z36A/iD2IrVQzrEsvp31cmU6f9VCyPIGiM0FSEXbj23JuPNUPCzSo5oAAiSZfs/hR9uuAx1xQFAfTzjYQ==</Q><DP>dsW7VGh5+OGro80K6BbivIEfBL1ZCyLO8Ciuw9o5u4ZSztU9skETPawHQYvN5WW+p0D3fdCd14ZFcavZ6j1OcQ==</DP><DQ>YSQBRzgjsEkVOCEzjsWYLUAAvwWBiLCEyolgzsaz2hvK4FZa9AspAa1MlJn768Ady8CJS1bhm/fqZA5R5GqQIQ==</DQ><InverseQ>zEGFnyMtfxSYHwRv8nZ4xVcFctnU2pYmmXXYv8NV5FvhZi8Z1f1GE3tmS8qDyIuDTrXjmII2cffLMjPOVmLKoQ==</InverseQ><D>Ii97qDg+oijuDbHNsd0DRIix81AQf+MG9BzvMPOSTgOgAruuxSjwaK4NLsrkgzCGVayx4wWfZXzOuiMK+rN2YPr6IPeut3O14uuwLH7brxkit+MnhclsCtKpdT2iuUGOnbEhWccepCO7YLyyczhT9GE0rEtbEK6S7wvVKab/osE=</D></RSAKeyValue>";
        private string senderPublicKey = "<RSAKeyValue><Modulus>rW0Prd+S+Z6Wv0gEakgSp/v8Pu4xJ6OjaVCHKTIcf/C5nZvE77454lii3Ne6odV+76oaM2Pn3I9kKehK7CtqklI7rc1+05WRE3u8O5tC5v2ECjEDPMULAcZVTjXSyZtSAOiqk+6nEcJGRED65aGXwFgZuxEY8y4FbUma3I311aM=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private DigitalSignatureResult digitalSignatureResult = new DigitalSignatureResult();

        public ServerPanel()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetFields();

            byte[] bytes = new byte[1024];
            byte[] bytes1 = new byte[1024];
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8888);

            try
            {
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(localEndPoint);
                listener.Listen(10);

                Socket handler = listener.Accept();
                ServerState.Text = "Connection established!";

                int bytesReceived = handler.Receive(bytes);

                string textReceived = Encoding.ASCII.GetString(bytes, 0, bytesReceived);

                string[] elements = textReceived.Split(Environment.NewLine);
                digitalSignatureResult.SetCipherText(elements[0]);
                digitalSignatureResult.SetSignatureText(elements[1]);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                listener.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered: " + ex.Message);
            }
        }

        private DigitalSignatureResult GetDigitalSignature(string cipher, string signature)
        {
            return new DigitalSignatureResult()
            {
                CipherText = cipher,
                SignatureText = signature
            };
        }

        private RSACryptoServiceProvider GetSenderCipher()
        {
            RSACryptoServiceProvider sender = new RSACryptoServiceProvider();
            sender.FromXmlString(senderPublicKey);
            return sender;
        }

        private RSACryptoServiceProvider GetReceiverCipher()
        {
            RSACryptoServiceProvider sender = new RSACryptoServiceProvider();
            sender.FromXmlString(rsaKeys);
            return sender;
        }

        private byte[] HashMessage(byte[] cipherBytes)
        {
            SHA1Managed sHA1Managed = new SHA1Managed();
            byte[] hash = sHA1Managed.ComputeHash(cipherBytes);

            return hash;
        }

        private void VerifySignature(byte[] hash, byte[] signature)
        {
            RSACryptoServiceProvider senderCipher = GetSenderCipher();
            RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(senderCipher);
            deformatter.SetHashAlgorithm("SHA1");

            if (!deformatter.VerifySignature(hash, signature))
            {
                throw new ApplicationException("Document Signature Was Not Verified");
            }
        }

        public string ObtainMessageFromHash(DigitalSignatureResult signatureResult)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(signatureResult.CipherText);
            byte[] signatureBytes = Convert.FromBase64String(signatureResult.SignatureText);
            byte[] newHash = HashMessage(cipherTextBytes);
            VerifySignature(newHash, signatureBytes);
            byte[] plainTextBytes = GetReceiverCipher().Decrypt(cipherTextBytes, false);

            return Encoding.UTF8.GetString(plainTextBytes);
        }

        private void ResetFields()
        {
            ServerState.PlaceholderText = "No Data Available";
            ReceivedText.PlaceholderText = "No Data Available";
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string hashResult = ObtainMessageFromHash(digitalSignatureResult);

            if (hashResult.Equals(MessageField.Text))
            {
                ReceivedText.Text = "Signature Verified" + Environment.NewLine + "Decrypted Message: " + Environment.NewLine + hashResult;
            }
            else
            {
                ReceivedText.Text = "Signature Was Not Verified";
            }
        }
    }
}

public struct DigitalSignatureResult
{
    public string? CipherText;
    public string? SignatureText;

    public string GetCipherText()
    {
        return CipherText;
    }

    public string GetSignatureText()
    {
        return SignatureText;
    }

    public void SetCipherText(string _cipherText)
    {
        CipherText = _cipherText;
    }

    public void SetSignatureText(string _signatureText)
    {
        SignatureText = _signatureText;
    }
}
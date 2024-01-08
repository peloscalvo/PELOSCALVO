using System;
using System.Security.Cryptography;
using System.Text;

namespace Comun
{
    public class ClasCodificarPass
    {
        public string Codificar(string Dato)
        {
            string Palabra = "Pelos y PelosCalvo";
            byte[] Data = UTF8Encoding.UTF8.GetBytes(Dato);
            MD5 md5 = MD5.Create();
            TripleDES Tripe = TripleDES.Create();
            Tripe.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Palabra));
            Tripe.Mode = CipherMode.ECB;
            ICryptoTransform Transform = Tripe.CreateEncryptor();
            byte[] Resust = Transform.TransformFinalBlock(Data, 0, Data.Length);
            return Convert.ToBase64String(Resust);
        }
        public string Dedificar(string Dato_E)
        {
            string Palabra = "Pelos y PelosCalvo";
            byte[] Data = Convert.FromBase64String(Dato_E);
            MD5 md5 = MD5.Create();
            TripleDES Tripe = TripleDES.Create();
            Tripe.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Palabra));
            Tripe.Mode = CipherMode.ECB;
            ICryptoTransform Transform = Tripe.CreateDecryptor();
            byte[] Resust = Transform.TransformFinalBlock(Data, 0, Data.Length);
            return UTF8Encoding.UTF8.GetString(Resust);
        }
    }
}

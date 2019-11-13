using System;
using System.Security.Cryptography;
using System.Text;

namespace AcceptanceTests
{
    class TaskFive
    {
        public static string createSign(string privateKey, string data)
        {
            byte[] hashOfDataToSign;//масив байтів під хеш
            //екземпляр сервісу для роботи з шифруванням (довжина ключа по замовчуванню 1024 біт)
            RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider();
            //використання SHA256 в межах цього блоку коду в якому,
            //перетворюємо рядок на масив байтів для обчислення хеша
            using (SHA1 sha1 = SHA1.Create())
            {
                hashOfDataToSign = sha1.ComputeHash(UnicodeEncoding.ASCII.GetBytes(data));
            }
            //екземпляр класу, що містить усі реалізації RSA
            RSA rsa = RSA.Create();
            //вивід у консоль ключів, що насправді будуть використані
            Console.WriteLine("Було використано ключі:\n" + rsaService.ToXmlString(true));
            //rsa.FromXmlString(privateKey);//використання переданого ключа
            //створює підпис
            RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsaService);
            //задання ключа
            rsaFormatter.SetKey(rsa);
            //задання SHA256 як хеш-функцію
            rsaFormatter.SetHashAlgorithm("SHA1");
            //повертається сформований та конвертований у рядок підпис
            return Convert.ToBase64String( rsaFormatter.CreateSignature(hashOfDataToSign));
        }
    }
}

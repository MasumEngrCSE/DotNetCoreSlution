using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///https://gigi.nullneuron.net/gigilabs/using-time-based-one-time-passwords-for-two-factor-authentication/

namespace ConsoleApp1._2fa.totp
{
    public class totpHelper
    {
        public totpHelper()
        {

        }

        public void GenerateSecret()
        {
            var secret = KeyGeneration.GenerateRandomKey(20);
            var base32Secret = Base32Encoding.ToString(secret);
            Console.WriteLine(base32Secret);
        }
        public void GeneratingTOTP(string base32Secret)
        {
            //string base32Secret = "6L4OH6DDC4PLNQBA5422GM67KXRDIQQP";
            var secret = Base32Encoding.ToBytes(base32Secret);

            var totp = new Totp(secret);
            var code = totp.ComputeTotp();

            //var backupCodes = totp.GenerateBackupCodes();


            Console.WriteLine(code);
        }

        public bool VerifyingTOTP(string base32Secret)
        {
            //string base32Secret = "6L4OH6DDC4PLNQBA5422GM67KXRDIQQP";
            var secret = Base32Encoding.ToBytes(base32Secret);

            var totp = new Totp(secret);

            while (true)
            {
                Console.Write("Enter code: ");
                string inputCode = Console.ReadLine();
                bool valid = totp.VerifyTotp(inputCode, out long timeStepMatched,
                    VerificationWindow.RfcSpecifiedNetworkDelay);

                string validStr = valid ? "Valid" : "Invalid";
                var colour = valid ? ConsoleColor.Green : ConsoleColor.Red;
                Console.ForegroundColor = colour;
                Console.WriteLine(validStr);
                Console.ResetColor();
            }
        }


        public void GenerateBackupCodesTOTP(string base32Secret)
        {
            var backupCodes = GenerateBackupCodes(10);
        }


        public static List<string> GenerateBackupCodes(int count)
        {
            var codes = new List<string>();
            var rng = new Random();

            for (var i = 0; i < count; i++)
            {
                var code = new string(Enumerable.Repeat("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ", 6)
                    .Select(s => s[rng.Next(s.Length)]).ToArray());
                codes.Add(code);
            }

            return codes;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlitedb.model;
using OtpNet;
using System.Text.RegularExpressions;
namespace sqlitedb.utilities
{
    public class Utils
    {

          
        public static void handleException(Exception ex)
        {
            MessageBox.Show(ex.Message,ex.Source,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void handleMessage(string message,string header)
        {
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string generateOTP()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            var base32String = Base32Encoding.ToString(key);
            var base32Bytes = Base32Encoding.ToBytes(base32String);
            var totp = new Totp(base32Bytes, mode: OtpHashMode.Sha512,totpSize:8,step:1);
            return totp.ComputeTotp();
        }

        public static void validatePerson(PersonModel model)
        {
            Regex emailRegex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            Regex phoneRegex = new Regex(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)");
            if (model.name == null || model.name.Length <= 0)
            {
                Exception ex= new Exception("Name Required");
                ex.Source = "Person Validation";
                throw ex;

            }
            if (model.phone.Length<10 || !phoneRegex.IsMatch(model.phone))
            {
                Exception ex = new Exception("Invalid Phone Number");
                ex.Source = "Person Validation";
                throw ex;

            }
            if (model.email.Length>0&&!emailRegex.IsMatch(model.email.Trim()))
            {
                Exception ex = new Exception("Email Address Invalid");
                ex.Source = "Person Validation";
                throw ex;
            }

        }
    }
}

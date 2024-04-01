using System.Text.RegularExpressions;

namespace N19_DentalClinic.library
{
    public class MyLibrary
    {
        public static bool checkValidField(string name, string email, string password, string confirmPassword, string phoneNumber)
        {

            if (name == "" || email == "" || password == "" || confirmPassword == "" || phoneNumber == "")
            {
                MessageBox.Show("Vui lòng điền hết thông tin");
                return false;
            }

            if (!isValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }

            if (!isValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, chứa ít nhất 1 ký tự số và 1 ký tự đặc biệt");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp");
                return false;
            }
            return true;
        }

        public static bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool isValidPassword(string password)
        {
            string regexPattern = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{6,}$";
            Regex regex = new Regex(regexPattern);
            return regex.IsMatch(password);
        }

        public static string formatEmail(string email)
        {
            return Regex.Replace(email, @"[.#$[\]]", "-");
        }
    }
}

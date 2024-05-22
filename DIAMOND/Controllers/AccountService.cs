namespace DIAMOND.Controllers
{
    public class AccountService
    {
        // Lưu trữ thông tin tài khoản trong một dictionary (chỉ để mục đích demo)
        private Dictionary<string, string> _accounts = new Dictionary<string, string>();

        public AccountService()
        {
            // Thêm tài khoản admin vào dictionary
            _accounts["admin"] = "admin";
        }

        // Phương thức này kiểm tra xem thông tin đăng nhập có hợp lệ không
        public bool ValidateCredentials(string username, string password)
        {
            // Kiểm tra xem username có tồn tại trong danh sách tài khoản không
            if (_accounts.ContainsKey(username))
            {
                // Kiểm tra xem password có đúng không
                return _accounts[username] == password;
            }
            return false;
        }
    }
}

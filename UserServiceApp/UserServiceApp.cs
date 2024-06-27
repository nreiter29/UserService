namespace UserServiceApp
{
    public partial class UserServiceApp : Form
    {
        private readonly UserService.UserService _userService = new UserService.UserService();

        public UserServiceApp()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            var role = roleTextBox.Text;

            var success = _userService.Register(username, password, role);
            MessageBox.Show(success ? "Registration successful" : "Registration failed");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            var success = _userService.Login(username, password);
            MessageBox.Show(success ? "Login successful" : "Login failed");
        }

        private void isInRoleButton_Click(object sender, EventArgs e)
        {
            var username = usernameInRoleTextBox.Text;
            var role = roleInRoleTextBox.Text;

            var isInRole = _userService.IsInRole(username, role);
            MessageBox.Show(isInRole ? "Users is in role" : "Users is not in role");
        }
    }
}
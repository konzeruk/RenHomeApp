using DTO.Models;
using RenHomeApp.Services;

namespace RenHomeApp.Forms
{
    public partial class AuthorizationForm : Form
    {
        public UserModelResponse? user = null;

        private GeneralService.Authorization authService;

        public AuthorizationForm()
        {
            InitializeComponent();

            authService = new GeneralService.Authorization();
        }
        private void bEntry_Click(object sender, EventArgs e)
        {
            if (!IsEmptyLoginOrPassword())
            {
                var login = textBoxLogin.Text;
                var password = textBoxPassword.Text;

                user = Task.Run(async () => await authService.GetUserAsync(login, password)).Result;

                if (user == null)
                {
                    labelError.Text = "Логин или пароль были введены не верно";
                    return;
                }

                Close();
            }
            else
                labelError.Text = "Логин или пароль не были введены";
        }

        private bool IsEmptyLoginOrPassword() =>
            (textBoxLogin.Text.Length == 0 && textBoxPassword.Text.Length == 0) ? true : false;

        private void bExit_Click(object sender, EventArgs e) =>
            Close();
    }
}

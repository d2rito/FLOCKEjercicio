using FLOCKAPI.Interfaces;

namespace FLOCKAPI.Classes
{
    public class User : IUser
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Enabled { get; set; } = false;

        public void ValidateUser()
        {
            if (UserName == "dorito" && Password == "contraseña")
                Enabled = true;
        }
    }
}

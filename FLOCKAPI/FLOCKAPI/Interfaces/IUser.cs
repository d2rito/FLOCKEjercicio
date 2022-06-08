namespace FLOCKAPI.Interfaces
{
    public interface IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public void ValidateUser();
    }
}

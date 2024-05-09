namespace VehicleRegistrationFE.Models.Response
{
    public class UserLoginResponse : BaseReponse
    {
        public UserLoginData Data { get; set; }
    }
    public class UserLoginData 
    {
        public string Username { get; set; }
        public bool IsActive { get; set; }
    }
}

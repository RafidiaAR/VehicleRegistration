namespace VehicleRegistrationFE.Models.Response
{
    public class BaseReponse
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public dynamic? Errors { get; set; }
    }
}

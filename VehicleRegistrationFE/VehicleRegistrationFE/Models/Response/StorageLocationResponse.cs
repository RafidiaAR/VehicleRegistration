namespace VehicleRegistrationFE.Models.Response
{
    public class StorageLocationResponse
    {
        public List<StorageLocation> data { get; set; }
    }
    public class StorageLocation 
    {
        public string LocationId { get; set; }
        public string LocationName { get; set; }
    }
}

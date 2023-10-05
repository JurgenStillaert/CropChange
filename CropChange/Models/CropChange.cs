// Models/CropChange.cs
namespace Crops.Models
{
    public class CropChange
    {
        public DateTime ModificationDate { get; set; }
        public int ParcelId { get; set; }
        public string NewEarlyCrop { get; set; } = "Green cover";
        public string NewMainCrop { get; set; }
        public string NewLateCrop { get; set; } = "Green cover";
    }
}

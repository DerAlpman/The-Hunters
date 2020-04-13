using System.Text.Json.Serialization;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class Flak
    {
        #region CONSTRUCTOR
        public Flak(string caliber)
        {
            Caliber = caliber;
            Status = DamageStatus.NO_DAMAGE;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public string Caliber { get; }

        [JsonIgnore]
        public DamageStatus Status { get; set; }
        #endregion PROPERTIES
    }
}

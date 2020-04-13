using System.Text.Json.Serialization;
using Component.TheHunters.Enumerations;

namespace Component.TheHunters.Models
{
    public class DeckGun
    {
        #region CONSTRUCTOR
        public DeckGun(string caliber, int maxAmmunition)
        {
            Caliber = caliber;
            MaxAmmunition = maxAmmunition;
            Status = DamageStatus.NO_DAMAGE;
        }
        #endregion CONSTRUCTOR

        #region PROPERTIES
        public string Caliber { get; }

        [JsonIgnore]
        public DamageStatus Status { get; set; }

        public int MaxAmmunition { get; }

        [JsonIgnore]
        public int CurrentAmmunition { get; set; }
        #endregion PROPERTIES
    }
}

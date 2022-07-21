namespace ScratchCards.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static ScratchCards.Entities.Common.DataConstants.GameType;
    public class GameType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(GameTypeNameMaxLength)]
        public string TypeName { get; set; }
    }
}

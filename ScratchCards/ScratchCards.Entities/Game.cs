namespace ScratchCards.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static ScratchCards.Entities.Common.DataConstants.Game;
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(GameNameMaxLength)]
        public string GameName { get; set; }

        [Required]
        public string BackgroundImagePath { get; set; }
    }
}

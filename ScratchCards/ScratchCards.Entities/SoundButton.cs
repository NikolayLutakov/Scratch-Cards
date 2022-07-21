namespace ScratchCards.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static ScratchCards.Entities.Common.DataConstants;
    public class SoundButton
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required]
        [MaxLength(FontMaxLength)]
        public string Font { get; set; }

        [Required]
        [MaxLength(FontColorMaxLength)]
        public string FontColor { get; set; }

        public string Background { get; set; }

        public string ButtonIconPath { get; set; }

        public int RenderPositionX { get; set; }

        public int RenderPositionY { get; set; }

        public int Width { get; set; }

        public int Heigth { get; set; }
    }
}

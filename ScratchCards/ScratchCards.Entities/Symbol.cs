namespace ScratchCards.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static ScratchCards.Entities.Common.DataConstants.Symbol;
    public class Symbol
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(SymbolContentMaxLength)]
        public string Content { get; set; }

        public string UnrevealdPicturePath { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public int GameTypeId { get; set; }

        public GameType GameType { get; set; }
    }
}

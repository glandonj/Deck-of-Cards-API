using System;
using Newtonsoft.Json;

namespace Deck_of_Cards_API_Lab.Models
{
    public partial class CardModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("cards")]
        public Card[] Cards { get; set; }

        [JsonProperty("remaining")]
        public long Remaining { get; set; }
    }

    public partial class Card
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("suit")]
        public string Suit { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("svg")]
        public Uri Svg { get; set; }

        [JsonProperty("png")]
        public Uri Png { get; set; }
    }
}


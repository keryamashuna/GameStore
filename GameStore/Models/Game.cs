using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GameStore.Models;

public partial class Game
{
    public int GameId { get; set; }

    public int AuthorId { get; set; }

    public string Name { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public DateTime Release { get; set; }

    public decimal Cost { get; set; }

    [JsonIgnore]
    public virtual Author Author { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GameStore.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int UserId { get; set; }

    public int GameId { get; set; }

    public string ReviewText { get; set; } = null!;

    public int Likes { get; set; }

    public int Dislikes { get; set; }

    public DateTime Date { get; set; }

    [JsonIgnore]
    public virtual Game Game { get; set; } = null!;

    [JsonIgnore]
    public virtual User User { get; set; } = null!;
}

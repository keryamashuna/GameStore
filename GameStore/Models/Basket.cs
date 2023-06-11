using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GameStore.Models;

public partial class Basket
{
    public int UserId { get; set; }

    public int GameId { get; set; }

    [JsonIgnore]
    public virtual Game Game { get; set; } = null!;

    [JsonIgnore]
    public virtual User User { get; set; } = null!;
}

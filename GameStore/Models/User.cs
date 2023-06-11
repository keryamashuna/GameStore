using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GameStore.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Nickname { get; set; } = null!;

    public string Email { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}

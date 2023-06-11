using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GameStore.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string Name { get; set; } = null!;

    public int PlatformCut { get; set; }

    [JsonIgnore]
    public virtual ICollection<Game> Games { get; } = new List<Game>();
}

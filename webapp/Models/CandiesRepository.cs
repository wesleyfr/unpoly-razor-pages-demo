using System.Collections.Concurrent;

namespace webapp.Models;

public static class CandiesRepository
{
    private static readonly ConcurrentDictionary<string, Candy> Candies = new ();
    private static readonly ConcurrentQueue<CandyEvent> Events = new ();

    public static Candy? GetCandy(string candyId)
    {
        if (!Candies.ContainsKey(candyId))
        {
            return null;
        }
        return Candies[candyId];
    }
    
    public static bool AddCandy(string name, DateTimeOffset? expirationDate = null, bool hasSpecialNote = false, string? specialNote = null, List<string>? comments = null)
    {
        var imgIndex = Candies.Count % CandiesFakeData.Images.Length;
        var id = StringUtils.RemoveDiacritics(name)
            .Replace(" ", "-")
            .ToLower();
        var candy = new Candy(id, name, expirationDate ?? DateTimeOffset.Now.Date, CandiesFakeData.Images[imgIndex], hasSpecialNote, specialNote, comments ?? new List<string>());
        var added = Candies.TryAdd(id, candy);
        if (added)
        {
            AddEvent(candy, $"Candy '{candy.Name}' added");
        }

        return added;
    }

    public static bool AddCandyComment(string candyId, string comment)
    {
        var candy = GetCandy(candyId);
        if (candy is null)
        {
            return false;
        }
        candy.Comments.Add(comment);
        AddEvent(candy, $"Candy '{candy.Name}' commented");
        return true;
    }

    public static void RemoveCandy(string candyId)
    {
        Candies.TryRemove(candyId, out var candy);
        if (candy is not null)
        {
            AddEvent(candy, $"Candy '{candy.Name}' removed");
        }
    }

    public static (int NbCandies, IReadOnlyList<Candy> Candies) SearchCandies(string? searchText, int skip, int take)
    {
        searchText = searchText ?? "";
        var candies = Candies
            .Where(candy => candy.Value.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            .OrderBy(candy => candy.Value.Name)
            .ToList();
        
        return (
            candies.Count,
            candies.Skip(skip)
                .Take(take)
                .Select(candy => candy.Value)
                .ToList());
    }

    public static int GetUnreadEventsCount()
    {
        return Events.Count(evt => !evt.IsRead);
    }

    public static CandyEvent[] GetEvents()
    {
        return Events.Reverse().ToArray();
    }

    public static void MarkEventsAreRead()
    {
        foreach (var evt in Events)
        {
            evt.IsRead = true;
        }
    }
    
    private static void AddEvent(Candy candy, string message)
    {
        Events.Enqueue(new CandyEvent(
            candy.Id, candy.Name, DateTimeOffset.Now, message));
    }
}

public record Candy(
    string Id, 
    string Name,
    DateTimeOffset ExpirationDate, 
    string ImageFilename,
    bool HasSpecialNote,
    string? SpecialNote,
    List<string> Comments);

public record CandyEvent(
    string Id,
    string Name,
    DateTimeOffset Date,
    string Message
)
{
    public bool IsRead { get; set; } = false;
}
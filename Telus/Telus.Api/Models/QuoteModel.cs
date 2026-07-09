namespace Telus.Api.Models;

public class QuoteModel
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public string? Author { get; set; }
}

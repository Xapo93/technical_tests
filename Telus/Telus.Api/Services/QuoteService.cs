using Telus.Api.Data;
using Telus.Api.Models;

namespace Telus.Api.Services;

public class QuoteService : IQuoteService
{
    public IEnumerable<QuoteModel> GetAll() => QuoteData.Quotes;

    public QuoteModel? GetById(int id) =>
        QuoteData.Quotes.FirstOrDefault(q => q.Id == id);

    public IEnumerable<QuoteModel> Search(string term) =>
        QuoteData.Quotes.Where(q =>
            q.Text.Contains(term, StringComparison.OrdinalIgnoreCase));
}

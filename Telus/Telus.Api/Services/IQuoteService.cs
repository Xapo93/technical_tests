using Telus.Api.Models;

namespace Telus.Api.Services;

public interface IQuoteService
{
    IEnumerable<QuoteModel> GetAll();
    QuoteModel? GetById(int id);
    IEnumerable<QuoteModel> Search(string term);
}

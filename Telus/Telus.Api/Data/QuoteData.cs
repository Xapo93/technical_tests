using Telus.Api.Models;

namespace Telus.Api.Data;

public static class QuoteData
{
    public static List<QuoteModel> Quotes { get; } = new()
    {
        new() { Id = 1, Text = "Genius is one percent inspiration and ninety-nine percent perspiration.", Author = "Thomas Edison" },
        new() { Id = 2, Text = "You can observe a lot just by watching.", Author = "Yogi Berra" },
        new() { Id = 3, Text = "A house divided against itself cannot stand.", Author = "Abraham Lincoln" },
        new() { Id = 4, Text = "Difficulties increase the nearer we get to the goal.", Author = "Johann Wolfgang von Goethe" },
        new() { Id = 5, Text = "Fate is in your hands and no one elses", Author = "Byron Pulsifer" },
        new() { Id = 6, Text = "Be the chief but never the lord.", Author = "Lao Tzu" },
        new() { Id = 7, Text = "Nothing happens unless first we dream.", Author = "Carl Sandburg" },
        new() { Id = 8, Text = "Well begun is half done.", Author = "Aristotle" },
        new() { Id = 9, Text = "Life is a learning experience, only if you learn.", Author = "Yogi Berra" },
        new() { Id = 10, Text = "Self-complacency is fatal to progress.", Author = "Margaret Sangster" },
        new() { Id = 11, Text = "Peace comes from within. Do not seek it without.", Author = "Buddha" },
        new() { Id = 12, Text = "What you give is what you get.", Author = "Byron Pulsifer" },
        new() { Id = 13, Text = "We can only learn to love by loving.", Author = "Iris Murdoch" },
        new() { Id = 14, Text = "Life is change. Growth is optional. Choose wisely.", Author = "Karen Clark" },
        new() { Id = 15, Text = "You'll see it when you believe it.", Author = "Wayne Dyer" },
        new() { Id = 16, Text = "Today is the tomorrow we worried about yesterday.", Author = null },
        new() { Id = 17, Text = "It's easier to see the mistakes on someone else's paper.", Author = null },
        new() { Id = 18, Text = "Every man dies. Not every man really lives.", Author = null },
        new() { Id = 19, Text = "To lead people walk behind them.", Author = "Lao Tzu" }
    };
}

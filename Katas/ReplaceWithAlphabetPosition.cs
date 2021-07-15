using System.Linq;

namespace Katas
{
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.Where(x => char.IsLetter(x)).
                Select(x => "abcdefghijklmnopqrstuvwxyz".IndexOf(x.ToString().ToLower()) + 1)
                .ToList());
        }
    }
}

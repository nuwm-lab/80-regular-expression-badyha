using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    // Клас відповідає за пошук ORCID у тексті
    // Інкапсуляція: регулярний вираз і Regex зберігаються як приватні поля
    public class OrcidFinder
    {
        private readonly string _pattern = "\\b\\d{4}-\\d{4}-\\d{4}-\\d{4}\\b";
        private readonly Regex _regex;

        public OrcidFinder()
        {
            _regex = new Regex(_pattern, RegexOptions.Compiled);
        }

        // Повертає список знайдених ORCID у вигляді рядків
        public IList<string> FindIn(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));

            var matches = _regex.Matches(text);
            var results = new List<string>();
            foreach (Match m in matches)
            {
                results.Add(m.Value);
            }

            return results;
        }
    }
}

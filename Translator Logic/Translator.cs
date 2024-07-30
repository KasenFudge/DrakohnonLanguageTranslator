using System.Text;

namespace Translator_Logic
{
    public class Translator
    {
        private string getLetter(char c)
        {
            StringBuilder result = new StringBuilder();
        }

        public string Translate(string s)
        {
            s = s.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                int current = (int)c;
            }

            return result.ToString();
        }
    }
}

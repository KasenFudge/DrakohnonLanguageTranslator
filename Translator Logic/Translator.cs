using System.Text;

namespace Translator_Logic
{
    public class Translator
    { 
        public string Translate(string s)
        {
            s = s.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                DrakohnonLetter dL = new DrakohnonLetter(c);
                result.Append(dL.ToString());
            }
            return result.ToString();
        }

        public string GetPronunciation(string s)
        {
            s = s.ToUpper();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                DrakohnonLetter dL = new DrakohnonLetter(s[i]);
                result.Append(dL.ToString());
                if (i + 1 < s.Length && Char.IsLetter(s[i+1]))
                {
                    result.Append("-");
                }
            }
            return result.ToString();
        }
    }
}

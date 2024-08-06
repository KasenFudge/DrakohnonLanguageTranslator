using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_Logic
{
    /// <summary>
    /// Base level of the translator, as the language is translated by translating
    /// each individual letter in a given word or phrase.
    /// </summary>
    public class DrakohnonLetter
    {
        /// <summary>
        /// Private Backing Field for TranslationLetter
        /// </summary>
        private string TranslatedLetter;

        /// <summary>
        /// Creates sets the value of TL for the TranslationLetter Property
        /// </summary>
        /// <param name="tB">The char being converted, assumed to be uppercase</param>
        public DrakohnonLetter(char tB)
        {
            switch (tB)
            {
                case 'A':
                    TranslatedLetter = "aw";
                    break;
                case 'B':
                    TranslatedLetter = "Bah";
                    break;
                case 'C':
                    TranslatedLetter = "crE";
                    break;
                case 'D':
                    TranslatedLetter = "Dro";
                    break;
                case 'E':
                    TranslatedLetter = "Eth";
                    break;
                case 'F':
                    TranslatedLetter = "frA";
                    break;
                case 'G':
                    TranslatedLetter = "Gaw";
                    break;
                case 'H':
                    TranslatedLetter = "Hu";
                    break;
                case 'I':
                    TranslatedLetter = "eI";
                    break;
                case 'J':
                    TranslatedLetter = "Jer";
                    break;
                case 'K':
                    TranslatedLetter = "kE";
                    break;
                case 'L':
                    TranslatedLetter = "Lo";
                    break;
                case 'M':
                    TranslatedLetter = "Mc";
                    break;
                case 'N':
                    TranslatedLetter = "Nz";
                    break;
                case 'O':
                    TranslatedLetter = "Or";
                    break;
                case 'P':
                    TranslatedLetter = "Per";
                    break;
                case 'Q':
                    TranslatedLetter = "Qu";
                    break;
                case 'R':
                    TranslatedLetter = "RR";
                    break;
                case 'S':
                    TranslatedLetter = "sE";
                    break;
                case 'T':
                    TranslatedLetter = "Ts";
                    break;
                case 'U':
                    TranslatedLetter = "Oth";
                    break;
                case 'V':
                    TranslatedLetter = "Vr";
                    break;
                case 'W':
                    TranslatedLetter = "wI";
                    break;
                case 'X':
                    TranslatedLetter = "Esk";
                    break;
                case 'Y':
                    TranslatedLetter = "Uo";
                    break;
                case 'Z':
                    TranslatedLetter = "Zst";
                    break;
                default:
                    TranslatedLetter = tB.ToString();
                    break;
            } // end switch
        } // end DrakohnonLetter(char)

        /// <summary>
        /// String Representation of DrakohnonLetter to be called in translating.
        /// </summary>
        /// <returns>The private string TL</returns>
        public override string ToString()
        {
            return TranslatedLetter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDecryptTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[]
            {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "",
                "чао"
            };
            Console.WriteLine(DecodeMessage(lines));
        }

        private static string DecodeMessage(string[] lines)
        {
            var withoutEmptyString = lines
                .Where(h => !string.IsNullOrEmpty(h));
            string[] GoodArray = withoutEmptyString.ToArray();
            String StringText = String.Join(" ", GoodArray);

            List<string> allWords = StringText.Split(' ').ToList();

            var onlyCapitalWords = allWords
                .Where(h => Char.IsUpper(h[0]));
            List<string> CapitalWords = onlyCapitalWords.ToList();
            CapitalWords.Reverse();

            String normalizedText = string.Join(" ", CapitalWords);
            normalizedText = normalizedText.ToLower();
            normalizedText = char.ToUpper(normalizedText[0]) + normalizedText.Substring(1) + ".";
            return normalizedText;
        }
    }
}

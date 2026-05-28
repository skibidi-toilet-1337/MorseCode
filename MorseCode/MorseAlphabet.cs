using System.Collections.Generic;
using System.Linq;

namespace MorseCode {
  internal static class MorseAlphabet {
    private static readonly Dictionary<char, string> _charToMorse = new Dictionary<char, string> {
        // Для написания содержимого словаря был использован ChatGPT
        // Латиница
        { 'A', ".-" },   { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." },  { 'E', "." },
        { 'F', "..-." }, { 'G', "--." },  { 'H', "...." }, { 'I', ".." },   { 'J', ".---" },
        { 'K', "-.-" },  { 'L', ".-.." }, { 'M', "--" },   { 'N', "-." },   { 'O', "---" },
        { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." },  { 'S', "..." },  { 'T', "-" },
        { 'U', "..-" },  { 'V', "...-" }, { 'W', ".--" },  { 'X', "-..-" }, { 'Y', "-.--" },
        { 'Z', "--.." },

        // Цифры
        { '1', ".----" }, { '2', "..---" }, { '3', "...-- " }, { '4', "....-" }, { '5', "....." },
        { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." }, { '0', "-----" }
    };

    private static readonly Dictionary<string, char> _charFromMorse = _charToMorse.ToDictionary(pair => pair.Value, pair => pair.Key);

    public static Dictionary<char, string> CharToMorse {
      get {
        return _charToMorse;
      }
    }

    public static Dictionary<string, char> CharFromMorse {
      get {
        return _charFromMorse;
      }
    }
  }
}

using System;
using System.Text;
using MorseCode;

public class MorseTranslator {
  public string EncodeInput(string text) {
    if (string.IsNullOrWhiteSpace(text)) {
      return string.Empty;
    }

    StringBuilder result = new StringBuilder();
    string upperText = text.ToUpper();

    for (int i = 0; i < upperText.Length; i++) {
      char symbol = upperText[i];

      if (symbol == ' ') {
        continue;
      }

      if (MorseAlphabet.CharToMorse.TryGetValue(symbol, out string morseCode)) {
        result.Append(morseCode);

        if (i + 1 < upperText.Length && upperText[i + 1] != ' ') {
          result.Append(" ");
        }
      }

      if (i + 1 < upperText.Length && upperText[i + 1] == ' ') {
        result.Append("   ");
      }
    }

    return result.ToString();
  }

  public string DecodeInput(string morseCode) {
    if (string.IsNullOrWhiteSpace(morseCode)) {
      return string.Empty;
    }

    StringBuilder result = new StringBuilder();

    string[] morseWords = morseCode.Split(new[] { "   " }, StringSplitOptions.RemoveEmptyEntries);

    foreach (string morseWord in morseWords) {
      string[] morseLetters = morseWord.Split(' ');

      foreach (string morseLetter in morseLetters) {
        if (MorseAlphabet.CharFromMorse.TryGetValue(morseLetter, out char letter)) {
          result.Append(letter);
        } else if (morseLetter == "/") {
          result.Append(" ");
        }
      }

      result.Append(" ");
    }

    return result.ToString().Trim();
  }
}
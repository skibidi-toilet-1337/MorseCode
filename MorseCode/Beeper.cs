using System;
using System.Threading;

public class Beeper : IMorsePlayer {
  private const int Frequency = 800;
  private const int DotDuration = 150;

  public void Play(string morseCode) {
    if (string.IsNullOrWhiteSpace(morseCode)) {
      return;
    }

    int dashDuration = DotDuration * 3;

    for (int i = 0; i < morseCode.Length; i++) {
      char symbol = morseCode[i];

      if (symbol == '.') {
        Console.Beep(Frequency, DotDuration);
        Thread.Sleep(DotDuration);
      } else if (symbol == '-') {
        Console.Beep(Frequency, dashDuration);
        Thread.Sleep(DotDuration);
      } else if (symbol == ' ') {
        if (i + 2 < morseCode.Length && morseCode[i + 1] == ' ' && morseCode[i + 2] == ' ') {
          Thread.Sleep(DotDuration * 4);
          i += 2;
        } else {
          Thread.Sleep(DotDuration * 2);
        }
      }
    }
  }
}
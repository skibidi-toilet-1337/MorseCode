using System;

internal class Program {
  private static void Main() {
    MorseTranslator translator = new MorseTranslator();
    IMorsePlayer player = new Beeper();

    MorseFacade morseManager = new MorseFacade(translator, player);

    Console.WriteLine("Меню");

    while (true) {
      Console.WriteLine("Выберите действие:\n" +
        "1.Закодировать текст и проиграть звук\n" +
        "2.Декодировать код Морзе\n" +
        "3.Выход\n");
      Console.Write("Выбор: ");

      string choice = Console.ReadLine();

      if (choice == "3") {
        break;
      }

      switch (choice) {
        case "1":
          Console.Write("Введите текст для кодирования: ");
          string textInput = Console.ReadLine();
          string encoded = translator.EncodeInput(textInput);
          Console.WriteLine($"Результат в Морзе: {encoded}\n" +
            "Воспроизведение сообщения в Морзе\n");
          player.Play(encoded);
          break;

        case "2":
          Console.Write("Введите код Морзе (буквы через 1 пробел, слова через 3 пробела): ");
          string morseInput = Console.ReadLine();

          string decoded = morseManager.Decode(morseInput);
          Console.WriteLine($"Расшифрованный текст: {decoded}");
          break;

        default:
          Console.WriteLine("Ошибка, введите свой выбор ещё раз");
          break;
      }
    }
  }
}
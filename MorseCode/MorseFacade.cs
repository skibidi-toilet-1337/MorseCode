public class MorseFacade {
  private readonly MorseTranslator _translator;
  private readonly IMorsePlayer _player;

  public MorseFacade(MorseTranslator translator, IMorsePlayer player) {
    _translator = translator;
    _player = player;
  }

  public string EncodeAndPlay(string text) {
    string morse = _translator.EncodeInput(text);
    _player.Play(morse);
    return morse;
  }

  public string Decode(string morseCode) {
    return _translator.DecodeInput(morseCode);
  }
}
using System;

// README.md를 읽고 코드를 작성하세요.
class InstrumentPlayer
{
    static void Main()
    {
        Instrument[] instruments =
    {
        new Piano(),
        new Guitar(),
        new Drum()
    };

        foreach (Instrument instrument in instruments)
        {
            instrument.Tune();
            instrument.Play();
            Console.WriteLine();
        }
    }
}



using System;
namespace ChromaticMethod
{
    public class Ionian
    {
        public string IonianBuilder(string Key)
        {
            if (Key == "C")
            {
                string[] scale = { "C", "D", "E", "F", "G", "A", "B" };
                foreach (var note in scale)
                {
                    return note;
                }
            }
            else if (Key == "D")
            {
                string[] scale = { "D", "E", "F#", "G", "A", "B", "C#" };
                foreach (var note in scale)
                {
                    return note;
                }
            }
            else
            {
                return "Not a valid key";
            }

            return "Not a valid key";
        }
    }
}

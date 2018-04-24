using System;
namespace ChromaticMethod
{
    public class Ionian
    {
        public static string IonianBuilder(string Key)
        {
          
            if (Key == "C")
            {
                string[] scaleNotes = { "C", "D", "E", "F", "G", "A", "B" };
                var I = scaleNotes[0];
                var II = scaleNotes[1];
                var III = scaleNotes[2];
                var IV = scaleNotes[3];
                var V = scaleNotes[4];
                var VI = scaleNotes[5];
                var VII = scaleNotes[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";

                return scale;
            }
            else if (Key == "D")
            {
                string[] scaleNotes = { "D", "E", "F#", "G", "A", "B", "C#" };
                var I = scaleNotes[0];
                var II = scaleNotes[1];
                var III = scaleNotes[2];
                var IV = scaleNotes[3];
                var V = scaleNotes[4];
                var VI = scaleNotes[5];
                var VII = scaleNotes[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";

                return scale;
            }


            return "invalid";
        }
    }
}
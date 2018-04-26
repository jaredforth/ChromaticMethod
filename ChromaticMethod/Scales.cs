using System;
namespace ChromaticMethod
{
    public static class Scales
    {
        public static string[] Major(string Key)
        {
            string[] C = { "C", "D", "E", "F", "G", "A", "B" };
            string[] Cs = { "C#", "D#", "E#", "F#", "G#", "A#", "B#" };
            string[] Db = { "Db", "Eb", "F", "Gb", "Ab", "Bb", "C" };
            string[] D = { "D", "E", "F#", "G", "A", "B", "C#" };
            string[] Ds = { "D#", "E#", "F#", "G#", "A#", "C", "D" };
            string[] Eb = { "Eb", "F", "G", "Ab", "Bb", "C", "D" };
            string[] E = { "E", "F#", "G#", "A", "B", "C#", "D#" };
            string[] F = { "F", "G", "A", "Bb", "C", "D", "E" };
            string[] Fs = { "F#", "G#", "A#", "B", "C#", "D#", "E#" };
            string[] Gb = { "Gb", "Ab", "Bb", "B", "Db", "Eb", "F" };
            string[] G = { "G", "A", "B", "C", "D", "E", "F#" };
            string[] Gs = { "G#", "A#", "B#", "C#", "D#", "E#", "G" };
            string[] Ab = { "Ab", "Bb", "C", "Db", "Eb", "F", "G" };
            string[] A = { "A", "B", "C#", "D", "E", "F#", "G#" };
            string[] As = { "A#", "B#", "C#", "D#", "E#", "F#", "G#" };
            string[] Bb = { "Bb", "Cb", "D", "Eb", "F", "G", "A" };
            string[] B = { "B", "C#", "D#", "E", "F#", "G#", "A#" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }

        public static string[] MinorPentatonic(string Key)
        {
            string[] C = { "C", "Eb", "F", "G", "Bb" };
            string[] Cs = { "C#", "E", "F#", "G#", "B" };
            string[] Db = { "Db", "E", "Gb", "Ab", "B" };
            string[] D = { "D", "F", "G", "A", "C" };
            string[] Ds = { "D#", "F#", "G#", "A#", "C#" };
            string[] Eb = { "Eb", "Gb", "Ab", "Bb", "Db" };
            string[] E = { "E", "G", "A", "B", "D" };
            string[] F = { "F", "Ab", "Bb", "C", "Eb" };
            string[] Fs = { "F#", "A", "B", "C#", "E" };
            string[] Gb = { "Gb", "A", "B", "Db", "E" };
            string[] G = { "G", "Bb", "C", "D", "F" };
            string[] Gs = { "G#", "B", "C#", "D#", "A#" };
            string[] Ab = { "Ab", "B", "Db", "Eb", "Gb" };
            string[] A = { "A", "C", "D", "E", "G" };
            string[] As = { "A#", "C#", "E#", "F", "G#" };
            string[] Bb = { "Bb", "Db", "E", "G", "Ab" };
            string[] B = { "B", "D", "E", "F#", "A" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }

        public static string[] MajorPentatonic(string Key)
        {
            string[] C = { "C", "D", "E", "G", "A" };
            string[] Cs = { "C#", "D#", "F", "G#", "A#" };
            string[] Db = { "Db", "Eb", "F", "Ab", "Bb" };
            string[] D = { "D", "E", "F#", "A", "B" };
            string[] Ds = { "D#", "F", "G", "A#", "C" };
            string[] Eb = { "Eb", "F", "Gb", "Bb", "C" };
            string[] E = { "E", "F#", "G#", "B", "C#" };
            string[] F = { "F", "G", "A", "C", "D" };
            string[] Fs = { "F#", "G#", "A#", "C#", "D#" };
            string[] Gb = { "Gb", "Ab", "Bb", "Db", "Eb" };
            string[] G = { "G", "A", "B", "D", "E" };
            string[] Gs = { "G#", "A#", "B#", "D#", "F" };
            string[] Ab = { "Ab", "Bb", "C", "Eb", "F" };
            string[] A = { "A", "B", "C#", "E", "F#" };
            string[] As = { "A#", "C", "D", "F", "G#" };
            string[] Bb = { "Bb", "C", "D", "F", "Ab" };
            string[] B = { "B", "C#", "D#", "F#", "G#" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }
        public static string[] MelodicMinor(string Key)
        {
            string[] C = { "C", "D", "Eb", "F", "G", "A", "B" };
            string[] Cs = { "C#", "D#", "E", "F#", "G#", "A#", "B#" };
            string[] Db = { "Db", "Eb", "E", "Gb", "Ab", "Bb", "C" };
            string[] D = { "D", "E", "F", "G", "A", "B", "C#" };
            string[] Ds = { "D#", "E#", "F#", "G#", "A#", "C", "D" };
            string[] Eb = { "Eb", "F", "Gb", "Ab", "Bb", "C", "D" };
            string[] E = { "E", "F#", "G", "A", "B", "C#", "D#" };
            string[] F = { "F", "G", "Ab", "Bb", "C", "D", "E" };
            string[] Fs = { "F#", "G#", "A", "B", "C#", "D#", "E#" };
            string[] Gb = { "Gb", "Ab", "A", "B", "Db", "Eb", "F" };
            string[] G = { "G", "A", "Bb", "C", "D", "E", "F#" };
            string[] Gs = { "G#", "A#", "B", "C#", "D#", "E#", "G" };
            string[] Ab = { "Ab", "Bb", "B", "Db", "Eb", "F", "G" };
            string[] A = { "A", "B", "C", "D", "E", "F#", "G#" };
            string[] As = { "A#", "B#", "C", "D#", "E#", "F#", "G#" };
            string[] Bb = { "Bb", "Cb", "Db", "Eb", "F", "G", "A" };
            string[] B = { "B", "C#", "D", "E", "F#", "G#", "A#" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }
        public static string[] MelodicMajor(string Key)
        {
            string[] C = { "C", "D", "E", "F", "G", "Ab", "Bb" };
            string[] Cs = { "C#", "D#", "F", "F#", "G#", "A", "B" };
            string[] Db = { "Db", "Eb", "F", "Gb", "Ab", "A", "B" };
            string[] D = { "D", "E", "F#", "G", "A", "Bb", "C" };
            string[] Ds = { "D#", "E#", "G", "G#", "A#", "B", "C#" };
            string[] Eb = { "Eb", "F", "G", "Ab", "Bb", "B", "Db" };
            string[] E = { "E", "F#", "G#", "A", "B", "C", "D" };
            string[] F = { "F", "G", "A", "Bb", "C", "Db", "Eb" };
            string[] Fs = { "F#", "G#", "A#", "B", "C#", "D", "E" };
            string[] Gb = { "Gb", "Ab", "Bb", "B", "Db", "D", "E" };
            string[] G = { "G", "A", "B", "C", "D", "Eb", "F" };
            string[] Gs = { "G#", "A#", "C", "C#", "D#", "E", "F#" };
            string[] Ab = { "Ab", "Bb", "C", "Db", "Eb", "E", "Gb" };
            string[] A = { "A", "B", "C#", "D", "E", "F", "G" };
            string[] As = { "A#", "B#", "D", "D#", "E#", "F", "G" };
            string[] Bb = { "Bb", "Cb", "D", "Eb", "F", "F", "G" };
            string[] B = { "B", "C#", "D#", "E", "F#", "G", "A" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }
        public static string[] EnigmaticMinor(string Key)
        {
            string[] C = { "C", "Db", "E", "F#", "G#", "A#", "B" };
            string[] Cs = { "C#", "D", "E#", "G", "A", "B", "C" };
            string[] Db = { "Db", "D", "F", "G", "A", "B", "C" };
            string[] D = { "D", "Eb", "F#", "G#", "A#", "B#", "C#" };
            string[] Ds = { "D#", "E", "F#", "A", "B", "C#", "D" };
            string[] Eb = { "Eb", "E", "G", "A", "B", "C#", "D" };
            string[] E = { "E", "F", "G#", "A#", "B#", "D", "D#" };
            string[] F = { "F", "Gb", "A", "B", "C#", "D#", "E" };
            string[] Fs = { "F#", "G", "A#", "B", "D", "E", "E#" };
            string[] Gb = { "Gb", "G", "Bb", "B", "D", "E", "F" };
            string[] G = { "G", "Ab", "B", "C#", "D#", "F", "F#" };
            string[] Gs = { "G#", "A", "B#", "D", "E", "F#", "G" };
            string[] Ab = { "Ab", "A", "C", "D", "E", "Gb", "G" };
            string[] A = { "A", "Bb", "C#", "D#", "F", "G", "G#" };
            string[] As = { "A#", "B", "C#", "E", "F", "A", "G#" };
            string[] Bb = { "Bb", "B", "D", "E", "F", "A", "Ab" };
            string[] B = { "B", "C", "D#", "F", "G", "A", "A#" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }
        }

        public static string[] WholeTone(string Key)
        {
            string[] C = { "C", "D", "E", "F#", "G#", "A#", "C" };
            string[] Cs = { "C#", "D#", "F", "G", "A", "B", "C#" };
            string[] Db = { "Db", "Eb", "F", "G", "A", "B", "Db" };
            string[] D = { "D", "E", "F#", "G#", "A#", "C", "D" };
            string[] Ds = { "D#", "E#", "G", "A", "B", "C#", "D#" };
            string[] Eb = { "Eb", "F", "G", "A", "B", "Db", "Eb" };
            string[] E = { "E", "F#", "G#", "A#", "B#", "D", "E" };
            string[] F = { "F", "G", "A", "B", "C#", "D#", "F" };
            string[] Fs = { "F#", "G#", "A#", "C", "D", "E", "F#" };
            string[] Gb = { "Gb", "Ab", "Bb", "C", "D", "E", "Gb" };
            string[] G = { "G", "A", "B", "C#", "D#", "F", "G" };
            string[] Gs = { "G#", "A#", "B#", "D", "E", "F", "G#" };
            string[] Ab = { "Ab", "Bb", "C", "D", "E", "F#", "Ab" };
            string[] A = { "A", "B", "C#", "D#", "F", "G", "A" };
            string[] As = { "A#", "B#", "C#", "E", "F", "G", "A#" };
            string[] Bb = { "Bb", "Cb", "D", "E", "F#", "G#", "Bb" };
            string[] B = { "B", "C#", "D#", "F", "G", "A", "B" };
            switch (Key)
            {
                case "C":
                    return C;
                case "C#":
                    return Cs;
                case "Db":
                    return Db;
                case "D":
                    return D;
                case "D#":
                    return Ds;
                case "Eb":
                    return Eb;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return Fs;
                case "Gb":
                    return Gb;
                case "G":
                    return G;
                case "G#":
                    return Gs;
                case "Ab":
                    return Ab;
                case "A":
                    return A;
                case "A#":
                    return As;
                case "Bb":
                    return Bb;
                case "B":
                    return B;
                default:
                    return C;
            }

        }
    }
}
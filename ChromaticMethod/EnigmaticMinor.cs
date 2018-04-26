using System;
namespace ChromaticMethod
{
    public class EnigmaticMinor
    {
        public static string[] C = { "C", "Db", "E", "F#", "G#", "A#", "B" };
        public static string[] Cs = { "C#", "D", "E#", "G", "A", "B", "C" };
        public static string[] Db = { "Db", "D", "F", "G", "A", "B", "C" };
        public static string[] D = { "D", "Eb", "F#", "G#", "A#", "B#", "C#" };
        public static string[] Ds = { "D#", "E", "F#", "A", "B", "C#", "D" };
        public static string[] Eb = { "Eb", "E", "G", "A", "B", "C#", "D" };
        public static string[] E = { "E", "F", "G#", "A#", "B#", "D", "D#" };
        public static string[] F = { "F", "Gb", "A", "B", "C#", "D#", "E" };
        public static string[] Fs = { "F#", "G", "A#", "B", "D", "E", "E#" };
        public static string[] Gb = { "Gb", "G", "Bb", "B", "D", "E", "F" };
        public static string[] G = { "G", "Ab", "B", "C#", "D#", "F", "F#" };
        public static string[] Gs = { "G#", "A", "B#", "D", "E", "F#", "G" };
        public static string[] Ab = { "Ab", "A", "C", "D", "E", "Gb", "G" };
        public static string[] A = { "A", "Bb", "C#", "D#", "F", "G", "G#" };
        public static string[] As = { "A#", "B", "C#", "E", "F", "A", "G#" };
        public static string[] Bb = { "Bb", "B", "D", "E", "F", "A", "Ab" };
        public static string[] B = { "B", "C", "D#", "F", "G", "A", "A#" };

        public static string ModeI(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{I} {II} {III} {IV} {V} {VI} {VII}";
                return scale;
            }
            return "invalid";
        }

        public static string ModeII(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{II} {III} {IV} {V} {VI} {VII} {I}";
                return scale;
            }

            return "invalid";
        }
        public static string ModeIII(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{III} {IV} {V} {VI} {VII} {I} {II}";
                return scale;
            }

            return "invalid";
        }
        public static string ModeIV(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{IV} {V} {VI} {VII} {I} {II} {III}";
                return scale;
            }

            return "invalid";
        }
        public static string ModeV(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{V} {VI} {VII} {I} {II} {III} {IV}";
                return scale;
            }

            return "invalid";
        }
        public static string ModeVI(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{VI} {VII} {I} {II} {III} {IV} {V}";
                return scale;
            }

            return "invalid";
        }
        public static string ModeVII(string Key)
        {
            if (Key == "C")
            {
                var I = C[0];
                var II = C[1];
                var III = C[2];
                var IV = C[3];
                var V = C[4];
                var VI = C[5];
                var VII = C[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "C#")
            {
                var I = Cs[0];
                var II = Cs[1];
                var III = Cs[2];
                var IV = Cs[3];
                var V = Cs[4];
                var VI = Cs[5];
                var VII = Cs[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "Db")
            {
                var I = Db[0];
                var II = Db[1];
                var III = Db[2];
                var IV = Db[3];
                var V = Db[4];
                var VI = Db[5];
                var VII = Db[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "D")
            {
                var I = D[0];
                var II = D[1];
                var III = D[2];
                var IV = D[3];
                var V = D[4];
                var VI = D[5];
                var VII = D[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "D#")
            {
                var I = Ds[0];
                var II = Ds[1];
                var III = Ds[2];
                var IV = Ds[3];
                var V = Ds[4];
                var VI = Ds[5];
                var VII = Ds[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "Eb")
            {
                var I = Eb[0];
                var II = Eb[1];
                var III = Eb[2];
                var IV = Eb[3];
                var V = Eb[4];
                var VI = Eb[5];
                var VII = Eb[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "E")
            {
                var I = E[0];
                var II = E[1];
                var III = E[2];
                var IV = E[3];
                var V = E[4];
                var VI = E[5];
                var VII = E[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "F")
            {
                var I = F[0];
                var II = F[1];
                var III = F[2];
                var IV = F[3];
                var V = F[4];
                var VI = F[5];
                var VII = F[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "F#")
            {
                var I = Fs[0];
                var II = Fs[1];
                var III = Fs[2];
                var IV = Fs[3];
                var V = Fs[4];
                var VI = Fs[5];
                var VII = Fs[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "Gb")
            {
                var I = Gb[0];
                var II = Gb[1];
                var III = Gb[2];
                var IV = Gb[3];
                var V = Gb[4];
                var VI = Gb[5];
                var VII = Gb[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "G")
            {
                var I = G[0];
                var II = G[1];
                var III = G[2];
                var IV = G[3];
                var V = G[4];
                var VI = G[5];
                var VII = G[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "G#")
            {
                var I = Gs[0];
                var II = Gs[1];
                var III = Gs[2];
                var IV = Gs[3];
                var V = Gs[4];
                var VI = Gs[5];
                var VII = Gs[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "Ab")
            {
                var I = Ab[0];
                var II = Ab[1];
                var III = Ab[2];
                var IV = Ab[3];
                var V = Ab[4];
                var VI = Ab[5];
                var VII = Ab[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "A")
            {
                var I = A[0];
                var II = A[1];
                var III = A[2];
                var IV = A[3];
                var V = A[4];
                var VI = A[5];
                var VII = A[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "A#")
            {
                var I = As[0];
                var II = As[1];
                var III = As[2];
                var IV = As[3];
                var V = As[4];
                var VI = As[5];
                var VII = As[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "Bb")
            {
                var I = Bb[0];
                var II = Bb[1];
                var III = Bb[2];
                var IV = Bb[3];
                var V = Bb[4];
                var VI = Bb[5];
                var VII = Bb[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }
            else if (Key == "B")
            {
                var I = B[0];
                var II = B[1];
                var III = B[2];
                var IV = B[3];
                var V = B[4];
                var VI = B[5];
                var VII = B[6];

                var scale = $"{VII} {I} {II} {III} {IV} {V} {VI} ";
                return scale;
            }

            return "invalid";
        }
    }
}
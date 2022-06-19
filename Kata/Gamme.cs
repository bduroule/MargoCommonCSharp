namespace Kata;
using System;

public class Gamme
{
    private readonly string[] notes = new string[] {"C", null, "D", null,  "E", "F", null, "G", null, "A", null, "B"};

    public void PrintNote()
    {
        int i = 2;
        for (int count = 0; count < 7; count++) {
            Console.Write($" {(notes[i] == null ? "#" : notes[i])}");
            i += 2;
            if (i >= notes.Length)
                i = i - notes.Length;
        }
         Console.WriteLine();
    }

    public int ParseNote(string note)
    {
        int res = 0;

        switch (note.Trim(' ', 'b', '♭', '#')) {
            case "C":
                res = 0;
                break;
            case "D": 
                res = 2;
                break;
            case "E":
                res = 4;
                break;
            case "F":
                res = 5;
                break;
            case "G": 
                res = 7;
                break;
            case "A":
                res = 9;
                break;
            case "B":
                res = 11;
                break;
            default:
                throw new Exception($"Invalid parameter: {note} not in range note");
        }
        if (note.Contains('#') || note.Contains('b'))
            res = note.Contains('#') ? res + 1 : res - 1;
        // Console.WriteLine($"\t res {notes[res + 1]} note {note} | ");
        return res;
    }

    public string GetAlteration(string note, int mode)
    {
        int i = mode;

        for (int count = 0; count <= 12; count++) {
            if (i == ParseNote(note)) {
                if (count % 11 == 6)
                    return $"{count % 11}{(note.Contains('b') ? 'b': '#')}";
                if (note.Contains('b') && !(count % 11 > 7))
                    return $"{(count % 11 > 7 ? 11 - count % 11 + 1 : count % 11)}b";
                return $"{(count % 11 > 7 ? 11 - count % 11 + 1 : count % 11)}{(count % 11 > 7 ? 'b' : '#')}";
            }
            i += 7;
            if (i >= notes.Length)
                i -= notes.Length;
        }
        return "";
    }

    public int IsToLongue(int pos, int range)
    {
        return pos + range >= notes.Length ? (pos + range) - notes.Length : pos + range;
    }

    public int IsToSmaler(int pos, int range)
    {
        return pos - range < 0 ? (pos - range) + notes.Length : pos - range;
    }

    public string SearchScale(string note, Func<int ,bool> functionMode)
    {
        int notePositition = ParseNote(note);
        bool IsSharp = GetAlteration(note, 9).Contains('#');
        int i = 0;
        string scale = "";

        Console.WriteLine($"posi {notePositition} {notes[i + notePositition]}");
        for (int count = 0; count < 7; count++) {
            Console.WriteLine($" TEST {functionMode(i)} {count} {i}= {scale}");
            if (notes[i + notePositition] != null && functionMode(i - 1)) {
                scale += $"{(IsSharp ? notes[IsToSmaler(i + notePositition, 2)] : notes[IsToLongue(i + notePositition, 2)])}{(IsSharp ? "##" : "♭♭")} ";
            }
            // else if (notes[i + notePositition] != null && scale.Contains(notes[i + notePositition])) {
            //     scale += $"{(IsSharp ? notes[IsToSmaler(i + notePositition, 1)] : notes[IsToLongue(i + notePositition, 1)])}{(IsSharp ? "#" : "♭")} ";
            // }
            else {
                if (notes[i + notePositition] == null)
                    scale += $"{(IsSharp ? notes[i + notePositition - 1] : notes[i + notePositition + 1])}{(IsSharp ? '#' : '♭')} ";
                else
                    scale += $"{notes[i + notePositition]} ";
            }
            if (functionMode(i))
                i++;
            else
                i += 2;
            if (i + notePositition >= notes.Length)
                i = i - notes.Length;
        }
        return scale.Trim(' ');
    }
    public string GetGamme(string note, string mode)
    {
        if (mode == "min")
            return SearchScale(note, index => index == 2 || index == 7);
        return SearchScale(note, index => index == 4 || index == 11);
    }
}
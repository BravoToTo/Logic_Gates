using System.Collections.Generic;

namespace Library;

public class CompuertaAND
{
    public List<bool> Entries = new List<bool>();
    public bool Output
    {
        get
        {
            return Entries.TrueForAll(x => x);
        }
    }

    public void AddEntry(params bool[] entries)
    {
        foreach (bool item in entries)
        {
            Entries.Add(item);
        }
    }
    public void RemoveEntry(bool entry)
    {
        Entries.Remove(entry);
    }
}
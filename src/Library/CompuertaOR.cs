using System.Collections.Generic;

namespace Library;

public class CompuertaOR
{
    public List<bool> Entries = new List<bool>();
    public bool Output
    {
        get
        {
            foreach (bool item in Entries)
            {
                if (item)
                {
                    return true;
                }
            }
            return false;
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
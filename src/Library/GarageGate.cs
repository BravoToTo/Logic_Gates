

namespace Library;

public class GarageGate
{
    public static bool Open(bool a, bool b, bool c)
    {
        var and1 = new CompuertaAND();
        var not1 = new CompuertaNOT(a);
        var not2 = new CompuertaNOT(b);
        var and2 = new CompuertaAND();
        var or1 = new CompuertaOR();
        var and3 = new CompuertaAND();

        and1.AddEntry(a,b);
        and2.AddEntry(not1.Output, not2.Output);
        or1.AddEntry(and1.Output, and2.Output);
        and3.AddEntry(or1.Output, c);

        return and3.Output;
    }
}
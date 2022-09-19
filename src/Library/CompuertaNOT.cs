using System.Collections.Generic;

namespace Library;

public class CompuertaNOT
{
    public bool Input;
    public bool Output;

    public CompuertaNOT(bool input)
    {
        this.Input = input;
        this.Output = !input;
    }
}
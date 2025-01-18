using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Gui.ConsoleDrivers.SilkNetDriver;
public class SilkNetDriver : ConsoleDriver
{
    public SilkNetDriver ()
    {
        ClearContents ();
    }

    public override void End ()
    {
        // throw new NotImplementedException ();
        Console.WriteLine ("End");
       this.End ();
    }

    public override bool GetCursorVisibility (out CursorVisibility visibility)
    {
        visibility = CursorVisibility.Default;
        Console.WriteLine ("GetCursorVisibility");
        return true;
    }

    public override MainLoop Init ()
    {
        Console.WriteLine ("Init");
        return new MainLoop(new SilkNetMainLoop ());
    }

    public override void SendKeys (char keyChar, ConsoleKey key, bool shift, bool alt, bool ctrl)
    {
        Console.WriteLine ("SendKeys");
        this.SendKeys (keyChar, key, shift, alt, ctrl);
    }

    public override bool SetCursorVisibility (CursorVisibility visibility)
    {
        Console.WriteLine ("SetCursorVisibility");
        return this.SetCursorVisibility (visibility);
    }

    public override void Suspend ()
    {
        Console.WriteLine ("Suspend");
        //throw new NotImplementedException ();
    }

    public override void UpdateCursor ()
    {
        Console.WriteLine ("UpdateCursor");
        //throw new NotImplementedException ();
    }

    public override bool UpdateScreen ()
    {
        Console.WriteLine ("UpdateScreen");
        //throw new NotImplementedException ();
        return true;
    }

    public override void WriteRaw (string ansi)
    {
        Console.WriteLine ("WriteRaw");
        //throw new NotImplementedException ();
    }

    private AnsiResponseParser _parser = new ();

    /// <inheritdoc />
    internal override IAnsiResponseParser GetParser () => _parser;
}

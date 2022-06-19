namespace OrientedObjectProgramation;
using System;

public class EventLab
{
    static protected void OnValueChanged(object o, EventArgs e) {
        Console.WriteLine("value was changed");
    }
}
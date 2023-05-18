using Supyrb;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


/// USAGE 
/*
 * declare signal attribute on top of a string type and another signal variable in script 
[Signal]
public string signalType = string.Empty;

[SerializeField]
Signal signal;

on Start, do this
    signal = SignalExtension.GetFromName( signalType );
    signal.AddListener( OnSignalTriggered );

for Signals with paramters, 
either use the type of signal you need or the final type of signal
e.g for a signal with int type.

[SerializeField]
Signal<int> signal;

singal =(Signal<int>) SignalExtension.GetFromName(signaltype);

OR 
[SerializeField]
SignalInt signal;

singal =(SignalInt) SignalExtension.GetFromName(signaltype);

*/

/// <summary>
/// Signal Attribute that draws signal types in inspector
/// </summary>
public class SignalAttribute : PropertyAttribute
{
    private List<SerializableSystemType> signalTypes = new List<SerializableSystemType>();

    public List<SerializableSystemType> SignalTypes
    {
        get
        {
            return signalTypes;
        }
    }

    public List<string> typestrings = new List<string>();
    public SignalAttribute()
    {
        
    }

    
}

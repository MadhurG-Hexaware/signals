using Supyrb;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

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

using Supyrb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static class SignalExtension
{
    public static Signal GetFromName(this Signal signal, string name)
    {
        string sig_type = name;
        Type type = null;
        Signal val = null;

        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach ( Assembly assembly in assemblies )
        {
            Type foundType = assembly.GetType( sig_type );
            if ( foundType != null )
            {
                type = foundType;
                break;
            }
        }


        if ( type != null )
        {
            val = (Signal)Signals.Get( type );
        }
        else
        {
            Debug.LogWarning( $"{name} - Signal is null" );
        }

        return val;
    }
}

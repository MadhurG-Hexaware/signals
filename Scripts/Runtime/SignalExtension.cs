using Supyrb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static class SignalExtension
{
    public static ISignal GetFromName( string name)
    {
        string sig_type = name;
        Type type = null;
        ISignal val = null;

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
            val = (ISignal)Signals.Get( type );
        }
        else
        {
            Debug.LogWarning( $"{name} - Signal is null" );
        }

        return val;
    }
}

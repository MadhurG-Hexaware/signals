using Supyrb;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SignalAttribute))]
public class SignalDrawer : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SignalAttribute dropdownAttribute = (SignalAttribute)attribute;

        if (dropdownAttribute.SignalTypes != null && dropdownAttribute.SignalTypes.Count > 0)
        {
            string[] options = dropdownAttribute.typestrings.ToArray();
            int currentIndex = System.Array.IndexOf(options, property.stringValue);

            if (currentIndex < 0)
            {
                currentIndex = 0;
                property.stringValue = options[currentIndex];
            }

            int newIndex = EditorGUI.Popup(position, label.text, currentIndex, options);
            if (newIndex != currentIndex)
            {
                property.stringValue = options[newIndex];
            }
        }
        else
        {
            FetchTypes();
            EditorGUI.PropertyField(position, property, label);
        }
    }

    public void FetchTypes()
    {
        SignalAttribute dropdownAttribute = (SignalAttribute)attribute;
        var types = new List<Type>();
        SignalReflectionHelper.GetAllDerivedClasses<ASignal>( ref types );
        dropdownAttribute.SignalTypes.Clear();
        for ( int i = 0; i < types.Count; i++ )
        {
            dropdownAttribute.typestrings.Add( types[i].Name );
            dropdownAttribute.SignalTypes.Add( new SerializableSystemType( types[i] ) );
        }
    }
}
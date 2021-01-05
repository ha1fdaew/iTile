﻿using Newtonsoft.Json;
using System.Reflection;
using xTile.ObjectModel;

namespace iTile.Core.Logic.SaveSystem
{
    public class PropertyProfile
    {
        public string Key { get; set; }

        public object Value { get; set; }

        [JsonConstructor]
        public PropertyProfile()
        {
        }

        public PropertyProfile(string key, PropertyValue value)
        {
            Key = key;
            Value = GetActualValue(value);
        }

        public PropertyValue ToPropertyValue()
        {
            if (Value is bool b)
                return new PropertyValue(b);
            else if (Value is int i)
                return new PropertyValue(i);
            else if (Value is float f)
                return new PropertyValue(f);
            else
                return new PropertyValue(Value.ToString());
        }

        private static object GetActualValue(PropertyValue value)
        {
            FieldInfo field = value.GetType().GetField("m_value", BindingFlags.Instance | BindingFlags.NonPublic);
            return field.GetValue(value);
        }
    }
}
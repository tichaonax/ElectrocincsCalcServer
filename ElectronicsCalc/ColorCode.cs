using System;
using System.Collections.Generic;

namespace ElectronicsCalc
{
    public class ValueMap
    {
        public int Value { get; set; }
        public int Multiplier { get; set; }

        public ValueMap(int value, int multiplier)
        {
            Value = value;
            Multiplier = multiplier;
        }
    }
    public static class ColorCode
    {
        // Use Dictionary as a map
        public static Dictionary<string, ValueMap> ColorCodeMap = new Dictionary<string, ValueMap>();

        static ColorCode()
        {
            ColorCodeMap.Add("pink", new ValueMap(0, -3));
            ColorCodeMap.Add("silver", new ValueMap(0, -2));
            ColorCodeMap.Add("gold", new ValueMap(0, 1));
            ColorCodeMap.Add("black", new ValueMap(0, 0));
            ColorCodeMap.Add("brown", new ValueMap(1, 1));
            ColorCodeMap.Add("red", new ValueMap(2, 2));
            ColorCodeMap.Add("orange", new ValueMap(3, 3));
            ColorCodeMap.Add("yellow", new ValueMap(4, 4));
            ColorCodeMap.Add("green", new ValueMap(5, 5));
            ColorCodeMap.Add("blue", new ValueMap(6, 6));
            ColorCodeMap.Add("violet", new ValueMap(7, 7));
            ColorCodeMap.Add("gray", new ValueMap(8, 8));
            ColorCodeMap.Add("white", new ValueMap(9, 9));
        }
    }
}

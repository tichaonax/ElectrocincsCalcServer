using System.Collections.Generic;

namespace ElectronicsCalc.ColorCoding
{
    public static class Tolerance
    {
        // Use Dictionary as a map
        public static Dictionary<string, string> ToleranceMap = new Dictionary<string, string>();
    
        static Tolerance()
        {
            // ... Add some keys and values.
            ToleranceMap.Add("none", "20%");
            ToleranceMap.Add("pink", "-");
            ToleranceMap.Add("silver", "10%");
            ToleranceMap.Add("gold", "5%");
            ToleranceMap.Add("black", "-");
            ToleranceMap.Add("brown", "1%");
            ToleranceMap.Add("red", "2%");
            ToleranceMap.Add("orange", "-");
            ToleranceMap.Add("yellow", "5%");
            ToleranceMap.Add("green", "0.5%");
            ToleranceMap.Add("blue", "0.25%");
            ToleranceMap.Add("violet", "0.1%");
            ToleranceMap.Add("gray", "0.05%");
            ToleranceMap.Add("white", "0.05%-10%");
        }
    }
}

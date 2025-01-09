using System;
using UnityEngine;

namespace Helvest.Tools
{
    // USEFUL Link https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html

    /// <summary>
    /// Hue Color Names List. (RGB 0.0-1.0)
    /// </summary>
    public enum ShortColor
    {
        // Basic Supported Colors Pre-defined by "Unity".
        White, // Solid white. RGBA is (1, 1, 1, 1).
        Black, // Solid black. RGBA is (0, 0, 0, 1).
        Clear, // Completely transparent. RGBA is (0, 0, 0, 0).
        Gray, // Gray. RGBA is (0.5, 0.5, 0.5, 1).
        Grey, // English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1).

        Red, // Solid red. RGBA is (1, 0, 0, 1).
        Green, // Solid green. RGBA is (0, 1, 0, 1).
        Blue, // Solid blue. RGBA is (0, 0, 1, 1).

        Cyan, // Cyan. RGBA is (0, 1, 1, 1).
        Magenta, //	Magenta. RGBA is (1, 0, 1, 1).
        Yellow, // Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!

        Aqua,
        Brown,
        Darkblue,
        Fuchsia,
        Lightblue,
        Lime,
        Maroon,
        Navy,
        Olive,
        Orange, // Orange. RGBA is (1, 0.648, 0, 1)
        Purple,
        Silver,
        Teal,

        Pink,
        Gold,
        Violet,
        Turquoise,
        Coral,
        Indigo,
        Mint,
        Salmon,
        Lavender,
        Khaki
    }

    public static class ShortColorExtension
    {
        #region ToHex

        public static string ToHex(this ShortColor color)
        {
            switch (color)
            {
                #region Basic

                default:
                case ShortColor.White:
                    return "ffffffff";

                case ShortColor.Black:
                    return "000000ff";

                case ShortColor.Clear:
                    return "00000000";

                case ShortColor.Grey:
                case ShortColor.Gray:
                    return "808080ff";

                #endregion

                #region RGB

                case ShortColor.Red:
                    return "ff0000ff";

                case ShortColor.Green:
                    return "008000ff";

                case ShortColor.Blue:
                    return "0000ffff";

                #endregion

                #region CMY

                case ShortColor.Cyan:
                case ShortColor.Aqua:
                    return "00ffffff";

                case ShortColor.Magenta:
                case ShortColor.Fuchsia:
                    return "ff00ffff";

                case ShortColor.Yellow:
                    return "ffff00ff";

                #endregion

                #region Other

                case ShortColor.Brown:
                    return "a52a2aff";
                case ShortColor.Darkblue:
                    return "0000a0ff";
                case ShortColor.Lightblue:
                    return "add8e6ff";
                case ShortColor.Lime:
                    return "00ff00ff";
                case ShortColor.Maroon:
                    return "800000ff";
                case ShortColor.Navy:
                    return "000080ff";
                case ShortColor.Olive:
                    return "808000ff";
                case ShortColor.Orange:
                    return "ffa500ff";
                case ShortColor.Purple:
                    return "800080ff";
                case ShortColor.Silver:
                    return "c0c0c0ff";
                case ShortColor.Teal:
                    return "008080ff";

                case ShortColor.Pink:
                    return "ffc0cbff";
                case ShortColor.Gold:
                    return "ffd700ff";
                case ShortColor.Violet:
                    return "8a2be2ff";
                case ShortColor.Turquoise:
                    return "40e0d0ff";
                case ShortColor.Coral:
                    return "ff7f50ff";
                case ShortColor.Indigo:
                    return "4b0082ff";
                case ShortColor.Mint:
                    return "98fb98ff";
                case ShortColor.Salmon:
                    return "fa8072ff";
                case ShortColor.Lavender:
                    return "e6e6faff";
                case ShortColor.Khaki:
                    return "f0e68cff";

                #endregion
            }
        }

        #endregion

        #region ToColor

        public static Color ToColor(this ShortColor color)
        {
            switch (color)
            {
                #region Basic

                default:
                case ShortColor.White:
                    return Color.white;
                case ShortColor.Black:
                    return Color.black;
                case ShortColor.Clear:
                    return new Color(0, 0, 0, 0);
                case ShortColor.Grey:
                case ShortColor.Gray:
                    return new Color(.5f, .5f, .5f);

                #endregion

                #region RGB

                case ShortColor.Red:
                    return Color.red;
                case ShortColor.Green:
                    return new Color(0, .502f, 0);
                case ShortColor.Blue:
                    return Color.blue;

                #endregion

                #region CMY

                case ShortColor.Cyan:
                case ShortColor.Aqua:
                    return Color.cyan;

                case ShortColor.Magenta:
                case ShortColor.Fuchsia:
                    return Color.magenta;

                case ShortColor.Yellow:
                    return Color.yellow;

                #endregion

                #region Other

                case ShortColor.Brown:
                    return new Color(.647f, .165f, .165f);
                case ShortColor.Darkblue:
                    return new Color(0, 0, .627f);
                case ShortColor.Lightblue:
                    return new Color(.678f, .847f, .902f);
                case ShortColor.Lime:
                    return Color.green;
                case ShortColor.Maroon:
                    return new Color(.502f, 0, 0);
                case ShortColor.Navy:
                    return new Color(0, 0, .502f);
                case ShortColor.Olive:
                    return new Color(.502f, .502f, 0);
                case ShortColor.Orange:
                    return new Color(1f, .647f, 0);
                case ShortColor.Purple:
                    return new Color(.502f, 0, .502f);
                case ShortColor.Silver:
                    return new Color(.753f, .753f, .753f);
                case ShortColor.Teal:
                    return new Color(0, .502f, .502f);

                case ShortColor.Pink:
                    return new Color(1f, 0.753f, 0.796f);
                case ShortColor.Gold:
                    return new Color(1f, 0.843f, 0);
                case ShortColor.Violet:
                    return new Color(0.541f, 0.169f, 0.886f);
                case ShortColor.Turquoise:
                    return new Color(0.251f, 0.878f, 0.816f);
                case ShortColor.Coral:
                    return new Color(1f, 0.498f, 0.313f);
                case ShortColor.Indigo:
                    return new Color(0.294f, 0, 0.510f);
                case ShortColor.Mint:
                    return new Color(0.596f, 0.984f, 0.596f);
                case ShortColor.Salmon:
                    return new Color(0.980f, 0.502f, 0.447f);
                case ShortColor.Lavender:
                    return new Color(0.902f, 0.902f, 1f);
                case ShortColor.Khaki:
                    return new Color(0.941f, 0.902f, 0.549f);

                #endregion
            }
        }

        #endregion

        #region Test

        public static void TestAllColor(string inputText)
        {
            ShortColor[] colors = (ShortColor[])Enum.GetValues(typeof(ShortColor));

            foreach (var textColor in colors)
            {
                Debug.Log($"Color in {textColor}: {inputText.Color(textColor)}");
            }
        }

        #endregion
    }
}
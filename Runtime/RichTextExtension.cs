using System;
using UnityEngine;

namespace Helvest.Tools
{
    /// <summary>
    /// This features help and make easier for you to work with "Rich Text" for your Debug.Log().
    /// </summary>
    public static class RichTextExtension
    {
        #region Color

        /// <summary>
        /// Use basic colors pre-defined by "Unity".
        /// Renders the text with the color names pre-define from "Unity".
        /// </summary>
        /// <param name="text">Content Text</param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string Color(this string text, ShortColor color)
        {
            return $"<color=#{color.ToHex()}>{text}</color>";
        }

        /// <summary>
        /// Convert the "RGB Color" to "Hex Color" value.
        /// Renders the text with your color settings.
        /// </summary>
        /// <param name="text">Content Text</param>
        /// <param name="color">RGB Color</param>
        /// <returns></returns>
        public static string Color(this string text, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";
        }

        #endregion

        #region Bold

        /// <summary>
        /// Renders the text in boldface.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Bold(this string text)
        {
            return $"<b>{text}</b>";
        }

        public static string Bold(this string text, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><b>{text}</b></color>";
        }

        public static string Bold(this string text, ShortColor color)
        {
            return $"<color=#{color.ToHex()}><b>{text}</b></color>";
        }

        #endregion

        #region Italic

        /// <summary>
        /// Renders the text in italics.
        /// </summary>
        /// <returns></returns>
        public static string Italic(this string text)
        {
            return $"<i>{text}</i>";
        }

        public static string Italic(this string text, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><i>{text}</i></color>";
        }

        public static string Italic(this string text, ShortColor color)
        {
            return $"<color=#{color.ToHex()}><i>{text}</i></color>";
        }

        #endregion

        #region ItalicBold

        /// <summary>
        /// Renders the text in italics and boldface.
        /// </summary>
        /// <returns></returns>
        public static string ItalicBold(this string text)
        {
            return $"<b><i>{text}</i></b>";
        }

        public static string ItalicBold(this string text, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><b><i>{text}</i></b></color>";
        }

        public static string ItalicBold(this string text, ShortColor color)
        {
            return $"<color=#{color.ToHex()}><b><i>{text}</i></b></color>";
        }

        #endregion

        #region Size

        /// <summary>
        /// Renders the text in a different size.
        /// </summary>
        /// <returns></returns>
        public static string Size(this string text, uint size)
        {
            return $"<size={size}>{text}</size>";
        }

        public static string Size(this string text, uint size, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><size={size}>{text}</size></color>";
        }

        public static string Size(this string text, uint size, ShortColor color)
        {
            return $"<color=#{color.ToHex()}><size={size}>{text}</size></color>";
        }

        #endregion

        #region Additional Tags

        public static string Hyperlink(this string text, string url)
        {
            return $"<a href=\"{url}\">{text}</a>";
        }

        public static string Align(this string text, TextAlignment alignment)
        {
            return $"<align=\"{alignment.ToString().ToLower()}\">{text}</align>";
        }

        public static string AlignJustified(this string text)
        {
            return $"<align=\"justified\">{text}</align>";
        }

        public static string AlignFlush(this string text)
        {
            return $"<align=\"flush\">{text}</align>";
        }

        public static string AllCaps(this string text)
        {
            return $"<allcaps>{text}</allcaps>";
        }

        public static string Alpha(this string text, string hexOpacity)
        {
            return $"<alpha={hexOpacity}>{text}</alpha>";
        }

        public static string LineBreak(this string text)
        {
            return $"{text}<br>";
        }

        public static string CharacterSpacing(this string text, float spacing)
        {
            return $"<cspace={spacing}>{text}</cspace>";
        }

        public static string Font(this string text, string fontName)
        {
            return $"<font=\"{fontName}\">{text}</font>";
        }

        public static string FontWeight(this string text, int weight)
        {
            return $"<font-weight=\"{weight}\">{text}</font-weight>";
        }

        public static string Gradient(this string text, string gradientName)
        {
            return $"<gradient=\"{gradientName}\">{text}</gradient>";
        }

        public static string Indent(this string text, float indentation)
        {
            return $"<indent={indentation}>{text}</indent>";
        }

        public static string LineHeight(this string text, float height)
        {
            return $"<line-height={height}>{text}</line-height>";
        }

        public static string LineIndent(this string text, float indent)
        {
            return $"<line-indent={indent}>{text}</line-indent>";
        }

        public static string Link(this string text, float id)
        {
            return $"<link=\"{id}\">{text}</link>";
        }

        public static string Lowercase(this string text)
        {
            return $"<lowercase>{text}</lowercase>";
        }

        public static string Margin(this string text, float margin)
        {
            return $"<margin={margin}>{text}</margin>";
        }

        public static string Mark(this string text, Color overlayColor)
        {
            return $"<mark=#{ColorUtility.ToHtmlStringRGBA(overlayColor)}>{text}</mark>";
        }

        public static string Mark(this string text, ShortColor color)
        {
            return $"<mark=#{color.ToHex()}>{text}</mark>";
        }

        public static string Monospace(this string text, float spacing)
        {
            return $"<mspace={spacing}>{text}</mspace>";
        }

        public static string NoBreak(this string text)
        {
            return $"<nobr>{text}</nobr>";
        }

        public static string NoParse(this string text)
        {
            return $"<noparse>{text}</noparse>";
        }

        public static string CaretPosition(this string text, float position)
        {
            return $"<pos={position}>{text}</pos>";
        }

        public static string Rotate(this string text, float degrees)
        {
            return $"<rotate=\"{degrees}\">{text}</rotate>";
        }

        public static string Strikethrough(this string text)
        {
            return $"<s>{text}</s>";
        }

        public static string SmallCaps(this string text)
        {
            return $"<smallcaps>{text}</smallcaps>";
        }

        public static string Space(this string text, float offset)
        {
            return $"<space={offset}>{text}</space>";
        }

        public static string Sprite(this string text, string spriteName)
        {
            return $"<sprite name=\"{spriteName}\">{text}</sprite>";
        }

        public static string Strikethrough(this string text, Color overlayColor)
        {
            return $"<strikethrough=#{ColorUtility.ToHtmlStringRGBA(overlayColor)}>{text}</strikethrough>";
        }

        public static string Style(this string text, string style)
        {
            return $"<style=\"{style}\">{text}</style>";
        }

        public static string Subscript(this string text)
        {
            return $"<sub>{text}</sub>";
        }

        public static string Superscript(this string text)
        {
            return $"<sup>{text}</sup>";
        }

        public static string Underline(this string text)
        {
            return $"<u>{text}</u>";
        }

        public static string Uppercase(this string text)
        {
            return $"<uppercase>{text}</uppercase>";
        }

        public static string BaselineOffset(this string text, float offset)
        {
            return $"<voffset={offset}>{text}</voffset>";
        }

        public static string HorizontalSize(this string text, float width)
        {
            return $"<width={width}>{text}</width>";
        }

        #endregion

        #region Test

        public static void TestAllRichTextFunctions(string inputText)
        {
            Debug.Log($"Input Text: {inputText}");

            Debug.Log($"Bold: {inputText.Bold()}");
            Debug.Log($"Italic: {inputText.Italic()}");
            Debug.Log($"ItalicBold: {inputText.ItalicBold()}");
            Debug.Log($"Scale: {inputText.Size(2)}");

            Debug.Log($"Hyperlink: {inputText.Hyperlink("https://www.unity.com")}");
            Debug.Log($"Align: {inputText.Align(TextAlignment.Center)}");
            Debug.Log($"AlignJustified: {inputText.AlignJustified()}");
            Debug.Log($"AlignFlush: {inputText.AlignFlush()}");
            Debug.Log($"AllCaps: {inputText.AllCaps()}");
            Debug.Log($"Alpha: {inputText.Alpha("#FF")}");
            Debug.Log($"LineBreak: {inputText.LineBreak()}");
            Debug.Log($"CharacterSpacing: {inputText.CharacterSpacing(1.5f)}");
            Debug.Log($"Font: {inputText.Font("Arial")}");
            Debug.Log($"FontWeight: {inputText.FontWeight(700)}");
            Debug.Log($"Gradient: {inputText.Gradient("Light to Dark Green - Vertical")}");
            Debug.Log($"Indent: {inputText.Indent(15f)}");
            Debug.Log($"LineHeight: {inputText.LineHeight(150f)}");
            Debug.Log($"LineIndent: {inputText.LineIndent(20f)}");
            Debug.Log($"Link: {inputText.Link(123)}");
            Debug.Log($"Lowercase: {inputText.Lowercase()}");
            Debug.Log($"Margin: {inputText.Margin(5f)}");
            Debug.Log($"Mark with Color: {inputText.Mark(new Color(1f, 1f, 0f, 0.7f))}");
            Debug.Log($"Mark with TextColor: {inputText.Mark(ShortColor.Yellow)}");
            Debug.Log($"Monospace: {inputText.Monospace(2.75f)}");
            Debug.Log($"NoBreak: {inputText.NoBreak()}");
            Debug.Log($"NoParse: {inputText.NoParse()}");
            Debug.Log($"CaretPosition: {inputText.CaretPosition(75f)}");
            Debug.Log($"Rotate: {inputText.Rotate(45f)}");
            Debug.Log($"Strikethrough: {inputText.Strikethrough()}");
            Debug.Log($"SmallCaps: {inputText.SmallCaps()}");
            Debug.Log($"Space: {inputText.Space(5f)}");
            Debug.Log($"Sprite: {inputText.Sprite("spriteName")}");
            Debug.Log($"Strikethrough with Color: {inputText.Strikethrough(new Color(1f, 0f, 0f, 0.5f))}");
            Debug.Log($"Style: {inputText.Style("H1")}");
            Debug.Log($"Subscript: {inputText.Subscript()}");
            Debug.Log($"Superscript: {inputText.Superscript()}");
            Debug.Log($"Underline: {inputText.Underline()}");
            Debug.Log($"Uppercase: {inputText.Uppercase()}");
            Debug.Log($"BaselineOffset: {inputText.BaselineOffset(1f)}");
            Debug.Log($"HorizontalSize: {inputText.HorizontalSize(60f)}");
        }

        #endregion
    }
}
using UnityEngine;

namespace RichText
{

	/// <summary>
	/// This features help and make easier for you to work with "Rich Text" for your Debug.Log().
	/// </summary>
	public static class RichTextExtension
	{

		#region ColorIt

		/// <summary>
		/// Use basic colors pre-defined by "Unity".
		/// Renders the text with the color names pre-define from "Unity".
		/// </summary>
		/// <param name="text">Content Text</param>
		/// <param name="name">RGBA by default</param>
		/// <returns></returns>
		public static string ColorIt(this string text, TextColor color)
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
		public static string ColorIt(this string text, Color color)
		{
			return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";
		}

		#endregion

		#region BoldIt

		/// <summary>
		/// Renders the text in boldface.
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static string BoldIt(this string text)
		{
			return $"<b>{text}</b>";
		}

		public static string BoldIt(this string text, Color color)
		{
			return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><b>{text}</b></color>";
		}

		public static string BoldIt(this string text, TextColor color)
		{
			return $"<color=#{color.ToHex()}><b>{text}</b></color>";
		}

		#endregion

		#region ItalicIt

		/// <summary>
		/// Renders the text in italics.
		/// </summary>
		/// <returns></returns>
		public static string ItalicIt(this string text)
		{
			return $"<i>{text}</i>";
		}

		public static string ItalicIt(this string text, Color color)
		{
			return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><i>{text}</i></color>";
		}

		public static string ItalicIt(this string text, TextColor color)
		{
			return $"<color=#{color.ToHex()}><i>{text}</i></color>";
		}

		#endregion

		#region ItalicBoldIt

		/// <summary>
		/// Renders the text in italics and boldface.
		/// </summary>
		/// <returns></returns>
		public static string ItalicBoldIt(this string text)
		{
			return $"<b><i>{text}</i></b>";
		}

		public static string ItalicBoldIt(this string text, Color color)
		{
			return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><b><i>{text}</i></b></color>";
		}

		public static string ItalicBoldIt(this string text, TextColor color)
		{
			return $"<color=#{color.ToHex()}><b><i>{text}</i></b></color>";
		}

		#endregion

		#region SizeIt

		/// <summary>
		/// Renders the text in a different size.
		/// </summary>
		/// <returns></returns>
		public static string SizeIt(this string text, uint size)
		{
			return $"<size={size}>{text}</size>";
		}

		public static string SizeIt(this string text, uint size, Color color)
		{
			return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}><size={size}>{text}</size></color>";
		}

		public static string SizeIt(this string text, uint size, TextColor color)
		{
			return $"<color=#{color.ToHex()}><size={size}>{text}</size></color>";
		}

		#endregion

		#region ToHex

		public static string ToHex(this TextColor color)
		{
			switch (color)
			{

				#region Basic

				default:
				case TextColor.White:
					return "ffffffff";

				case TextColor.Black:
					return "000000ff";

				case TextColor.Clear:
					return "00000000";

				case TextColor.Grey:
				case TextColor.Gray:
					return "808080ff";

				#endregion

				#region RGB

				case TextColor.Red:
					return "ff0000ff";

				case TextColor.Green:
					return "008000ff";

				case TextColor.Blue:
					return "0000ffff";

				#endregion

				#region CMY

				case TextColor.Cyan:
				case TextColor.Aqua:
					return "00ffffff";

				case TextColor.Magenta:
				case TextColor.Fuchsia:
					return "ff00ffff";

				case TextColor.Yellow:
					return "ffff00ff";

				#endregion

				#region Other

				case TextColor.Brown:
					return "a52a2aff";
				case TextColor.Darkblue:
					return "0000a0ff";
				case TextColor.Lightblue:
					return "add8e6ff";
				case TextColor.Lime:
					return "00ff00ff";
				case TextColor.Maroon:
					return "800000ff";
				case TextColor.Navy:
					return "000080ff";
				case TextColor.Olive:
					return "808000ff";
				case TextColor.Orange:
					return "ffa500ff";
				case TextColor.Purple:
					return "800080ff";
				case TextColor.Silver:
					return "c0c0c0ff";
				case TextColor.Teal:
					return "008080ff";

					#endregion

			}
		}

		#endregion

	}

}

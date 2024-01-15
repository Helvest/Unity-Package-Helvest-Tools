using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Helvest.Tools
{

	[Serializable]
	public class QuickLog
	{

		#region Enums

		[Flags]
		public enum DebugLevel
		{
			None = 0,
			AllLog = LogInfo | LogDebug | LogWarning | LogException | LogError,
			LogInfo = 1,
			LogDebug = 1 << 1,
			LogWarning = 1 << 2,
			LogException = 1 << 3,
			LogError = 1 << 4,
			UseDebugAction = 1 << 5,
			Everything = 63
		}

		#endregion

		#region Fields

		public Object cachedContext = default;

#if UNITY_EDITOR
		[SerializeField]
		private bool _useColor = false;
		[SerializeField]
		[ColorUsage(false, false)]
		private Color _defaultColor = Color.white;

		[SerializeField]
		private bool _useBold = false;
		[SerializeField]
		private bool _useItalic = false;
#endif

		public DebugLevel debugLevelInBuild = DebugLevel.LogException | DebugLevel.LogError;
		public DebugLevel debugLevelInDebug = DebugLevel.LogWarning | DebugLevel.LogException | DebugLevel.LogError;
		public DebugLevel debugLevelInEditor = DebugLevel.Everything;

#if UNITY_EDITOR
		public DebugLevel GetDebugLevel => debugLevelInEditor;
		public readonly bool isBuild = false;
		public readonly bool isDebugBuild = false;
		public readonly bool isEditor = true;
#elif DEBUG
		public DebugLevel GetDebugLevel => debugLevelInDebug;
		public readonly bool isBuild = true;
		public readonly bool isDebugBuild = true;
		public readonly bool isEditor = false;
#else
		public DebugLevel GetDebugLevel => debugLevelInBuild;
		public readonly bool isBuild = true;
		public readonly bool isDebugBuild = false;
		public readonly bool isEditor = false;
#endif

		#endregion

		#region Logs

		public void Log(string msg, DebugLevel level, Object context = null, Color color = default)
		{
			if (!GetDebugLevel.HasFlag(level))
			{
				return;
			}

			context = context != null ? context : cachedContext;

#if UNITY_EDITOR
			if (color != default)
			{
				msg = msg.Color(color);
			}
			else if (_useColor)
			{
				msg = msg.Color(_defaultColor);
			}

			if (_useBold)
			{
				msg = msg.Bold();
			}

			if (_useItalic)
			{
				msg = msg.Italic();
			}
#endif

			switch (level)
			{
				case DebugLevel.LogInfo:
				case DebugLevel.LogDebug:
					Debug.Log(msg, context);
					break;
				case DebugLevel.LogWarning:
					Debug.LogWarning(msg, context);
					break;
				case DebugLevel.LogException:
				case DebugLevel.LogError:
					Debug.LogError(msg, context);
					break;
				case DebugLevel.None:
					break;
			}
		}

		#endregion

		#region Logs shortcut

		public void LogInfo(string msg, Object context = null, Color color = default)
		{
			Log(msg, DebugLevel.LogInfo, context, color);
		}

		public void Log(object ob, Object context = null, Color color = default)
		{
			Log(ob.ToString(), DebugLevel.LogDebug, context, color);
		}

		public void Log(string msg, Object context = null, Color color = default)
		{
			Log(msg, DebugLevel.LogDebug, context, color);
		}

		public void LogWarning(string msg, Object context = null, Color color = default)
		{
			Log(msg, DebugLevel.LogWarning, context, color);
		}

		public void LogException(Exception e, Object context = null)
		{
			if (!GetDebugLevel.HasFlag(DebugLevel.LogException))
			{
				return;
			}

			context = context != null ? context : cachedContext;
			Debug.LogException(e, context);
		}

		public void LogError(string msg, Object context = null, Color color = default)
		{
			Log(msg, DebugLevel.LogError, context, color);
		}

		#endregion

	}

}
// DO NOT EDIT: generated by fsdgencsharp
using System;
using Facility.Core;
using Newtonsoft.Json;

namespace Facility.ExampleApi
{
	/// <summary>
	/// An obsolete enum.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[Obsolete]
	[JsonConverter(typeof(ObsoleteEnumJsonConverter))]
	public struct ObsoleteEnum
	{
		public static readonly ObsoleteEnum Unused = new ObsoleteEnum("unused");

		/// <summary>
		/// Creates an instance.
		/// </summary>
		public ObsoleteEnum(string value)
		{
			m_value = value;
		}

		/// <summary>
		/// Converts the instance to a string.
		/// </summary>
		public override string ToString()
		{
			return m_value ?? "";
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public bool Equals(ObsoleteEnum other)
		{
			return StringComparer.OrdinalIgnoreCase.Equals(ToString(), other.ToString());
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is ObsoleteEnum && Equals((ObsoleteEnum) obj);
		}

		/// <summary>
		/// Gets the hash code.
		/// </summary>
		public override int GetHashCode()
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(ToString());
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public static bool operator ==(ObsoleteEnum left, ObsoleteEnum right)
		{
			return left.Equals(right);
		}

		/// <summary>
		/// Checks for inequality.
		/// </summary>
		public static bool operator !=(ObsoleteEnum left, ObsoleteEnum right)
		{
			return !left.Equals(right);
		}

		/// <summary>
		/// Used for JSON serialization.
		/// </summary>
		public sealed class ObsoleteEnumJsonConverter : ServiceEnumJsonConverter<ObsoleteEnum>
		{
			protected override ObsoleteEnum CreateCore(string value)
			{
				return new ObsoleteEnum(value);
			}
		}

		readonly string m_value;
	}
}
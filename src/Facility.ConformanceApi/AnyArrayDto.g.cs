// DO NOT EDIT: generated by fsdgencsharp
// <auto-generated />
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ConformanceApi
{
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class AnyArrayDto : ServiceDto<AnyArrayDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public AnyArrayDto()
		{
		}

		public IReadOnlyList<string> String { get; set; }

		public IReadOnlyList<bool> Boolean { get; set; }

		public IReadOnlyList<double> Double { get; set; }

		public IReadOnlyList<int> Int32 { get; set; }

		public IReadOnlyList<long> Int64 { get; set; }

		public IReadOnlyList<decimal> Decimal { get; set; }

		public IReadOnlyList<byte[]> Bytes { get; set; }

		public IReadOnlyList<JObject> Object { get; set; }

		public IReadOnlyList<ServiceErrorDto> Error { get; set; }

		public IReadOnlyList<AnyDto> Data { get; set; }

		public IReadOnlyList<Answer> Enum { get; set; }

		public IReadOnlyList<IReadOnlyList<int>> Array { get; set; }

		public IReadOnlyList<IReadOnlyDictionary<string, int>> Map { get; set; }

		public IReadOnlyList<ServiceResult<int>> Result { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(AnyArrayDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentFieldValues(String, other.String) &&
				ServiceDataUtility.AreEquivalentFieldValues(Boolean, other.Boolean) &&
				ServiceDataUtility.AreEquivalentFieldValues(Double, other.Double) &&
				ServiceDataUtility.AreEquivalentFieldValues(Int32, other.Int32) &&
				ServiceDataUtility.AreEquivalentFieldValues(Int64, other.Int64) &&
				ServiceDataUtility.AreEquivalentFieldValues(Decimal, other.Decimal) &&
				ServiceDataUtility.AreEquivalentFieldValues(Bytes, other.Bytes) &&
				ServiceDataUtility.AreEquivalentFieldValues(Object, other.Object) &&
				ServiceDataUtility.AreEquivalentFieldValues(Error, other.Error) &&
				ServiceDataUtility.AreEquivalentFieldValues(Data, other.Data) &&
				ServiceDataUtility.AreEquivalentFieldValues(Enum, other.Enum) &&
				ServiceDataUtility.AreEquivalentFieldValues(Array, other.Array) &&
				ServiceDataUtility.AreEquivalentFieldValues(Map, other.Map) &&
				ServiceDataUtility.AreEquivalentFieldValues(Result, other.Result);
		}
	}
}
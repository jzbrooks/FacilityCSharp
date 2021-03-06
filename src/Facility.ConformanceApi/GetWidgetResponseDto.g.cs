// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Response for GetWidget.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GetWidgetResponseDto : ServiceDto<GetWidgetResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetWidgetResponseDto()
		{
		}

		/// <summary>
		/// The requested widget.
		/// </summary>
		public WidgetDto Widget { get; set; }

		/// <summary>
		/// The ETag of the widget.
		/// </summary>
		public string ETag { get; set; }

		/// <summary>
		/// The widget still has the specified ETag.
		/// </summary>
		public bool? NotModified { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetResponseDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentDtos(Widget, other.Widget) &&
				ETag == other.ETag &&
				NotModified == other.NotModified;
		}
	}
}

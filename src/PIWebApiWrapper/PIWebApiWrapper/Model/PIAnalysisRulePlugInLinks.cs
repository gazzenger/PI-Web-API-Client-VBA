// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("5B1C9100-6389-4D5E-8341-703C9EDFDDE7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisRulePlugInLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AssetServer { get; set; }

	}

	[Guid("D0517F29-03EC-40EA-910E-FC0897B8B687")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisRulePlugInLinks))]
	[ProgId("PIWebAPIWrapper.PIAnalysisRulePlugInLinks")]
	[DataContract]

	public class PIAnalysisRulePlugInLinks : IPIAnalysisRulePlugInLinks
	{
		public PIAnalysisRulePlugInLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

	}
}

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

	[Guid("5F5F736B-6697-419D-BBDC-19D59BB0C2C7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEnumerationValueLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string EnumerationSet { get; set; }

		[DispId(3)]
		string Parent { get; set; }

	}

	[Guid("F761585F-ABC4-4F98-A2E6-B7EC3349178C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEnumerationValueLinks))]
	[ProgId("PIWebAPIWrapper.PIEnumerationValueLinks")]
	[DataContract]

	public class PIEnumerationValueLinks : IPIEnumerationValueLinks
	{
		public PIEnumerationValueLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "EnumerationSet", EmitDefaultValue = false)]
		public string EnumerationSet { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

	}
}

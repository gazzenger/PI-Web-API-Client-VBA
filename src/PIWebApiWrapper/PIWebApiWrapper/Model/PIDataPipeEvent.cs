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

	[Guid("9EA24068-88BA-4F9E-9F31-EEF3A402E13B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIDataPipeEvent
	{
		[DispId(1)]
		string Action { get; set; }

		[DispId(2)]
		string Timestamp { get; set; }

		[DispId(3)]
		string UnitsAbbreviation { get; set; }

		[DispId(4)]
		bool Good { get; set; }

		[DispId(5)]
		bool Questionable { get; set; }

		[DispId(6)]
		bool Substituted { get; set; }

		[DispId(7)]
		bool Annotated { get; set; }

		[DispId(8)]
		object Value { get; set; }

		[DispId(9)]
		void SetValueWithString(string value);

		[DispId(10)]
		void SetValueWithInt(int value);

		[DispId(11)]
		void SetValueWithDouble(double value);

		[DispId(12)]
		PIPropertyError[] Errors { get; set; }

		[DispId(13)]
		PIWebException WebException { get; set; }

	}

	[Guid("7D893074-F116-4008-BE6C-8DE5E338BE8C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIDataPipeEvent))]
	[ProgId("PIWebAPIWrapper.PIDataPipeEvent")]
	[DataContract]

	public class PIDataPipeEvent : IPIDataPipeEvent
	{
		public PIDataPipeEvent()
		{
		}

		[DataMember(Name = "Action", EmitDefaultValue = false)]
		public string Action { get; set; }

		[DataMember(Name = "Timestamp", EmitDefaultValue = false)]
		public string Timestamp { get; set; }

		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		[DataMember(Name = "Good", EmitDefaultValue = false)]
		public bool Good { get; set; }

		[DataMember(Name = "Questionable", EmitDefaultValue = false)]
		public bool Questionable { get; set; }

		[DataMember(Name = "Substituted", EmitDefaultValue = false)]
		public bool Substituted { get; set; }

		[DataMember(Name = "Annotated", EmitDefaultValue = false)]
		public bool Annotated { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public object Value { get; set; }

		public void SetValueWithString(string value)
		{
			Value = value;
		}

		public void SetValueWithInt(int value)
		{
			Value = value;
		}

		public void SetValueWithDouble(double value)
		{
			Value = value;
		}

		[DataMember(Name = "Errors", EmitDefaultValue = false)]
		public PIPropertyError[] Errors { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}

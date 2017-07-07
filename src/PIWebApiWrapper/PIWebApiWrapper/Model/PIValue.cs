// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("1A584B3E-B37D-4DED-8D56-2865DCAF78EC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIValue
	{
		[DispId(1)]
		object Value { get; set; }

		[DispId(2)]
		void SetValueWithString(string value);

		[DispId(3)]
		void SetValueWithInt(int value);

		[DispId(4)]
		void SetValueWithDouble(double value);

		[DispId(5)]
		PIErrors Exception { get; set; }

	}

	[Guid("47BA36F4-48E9-48E3-B3D8-537E6A94D3B9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIValue))]
	[ProgId("PIWebAPIWrapper.PIValue")]
	[DataContract]

	public class PIValue : IPIValue
	{
		public PIValue()
		{
		}

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

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}

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
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("21F786D7-ACB3-46AB-BD7E-B06177603FE7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamUpdatesRegister
	{
		[DispId(1)]
		PIItemsStreamUpdatesRegister Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("DA19F454-2DF5-4D05-A286-A572DBEFA0E2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamUpdatesRegister))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamUpdatesRegister")]
	public class ApiResponsePIItemsStreamUpdatesRegister : ApiParentResponse, IApiResponsePIItemsStreamUpdatesRegister
	{
		public PIItemsStreamUpdatesRegister Data { get; set; }
		public ApiResponsePIItemsStreamUpdatesRegister(int statusCode, IDictionary<string, string> headers, PIItemsStreamUpdatesRegister data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

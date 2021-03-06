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
	[Guid("54F2A8A9-4C8B-4270-92DD-29A5BED21A03")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnit
	{
		[DispId(1)]
		PIUnit Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("772E3DEA-26E2-4739-B46A-56418C2BB1E5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUnit))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUnit")]
	public class ApiResponsePIUnit : ApiParentResponse, IApiResponsePIUnit
	{
		public PIUnit Data { get; set; }
		public ApiResponsePIUnit(int statusCode, IDictionary<string, string> headers, PIUnit data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

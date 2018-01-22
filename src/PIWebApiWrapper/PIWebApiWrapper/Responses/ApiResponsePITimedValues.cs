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
	[Guid("61527B71-6B35-44C3-8F6A-915BF61D84DF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimedValues
	{
		[DispId(1)]
		PITimedValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("66C95EF3-6E4B-49D7-B148-9DFFFCA660A2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimedValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimedValues")]
	public class ApiResponsePITimedValues : ApiParentResponse, IApiResponsePITimedValues
	{
		public PITimedValues Data { get; set; }
		public ApiResponsePITimedValues(int statusCode, IDictionary<string, string> headers, PITimedValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

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
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("A0726ABC-967C-446A-8150-2BB99CC18C81")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnit
	{
		[DispId(1)]
		PIUnit Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("489308A6-7EBA-4640-8859-B0B0DDF3A002")]
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

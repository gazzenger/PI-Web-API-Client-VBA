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
	[Guid("AA3C226C-D123-4387-B269-31EEE07AA155")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemEventFrame
	{
		[DispId(1)]
		PIItemEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("452AFEF0-74C5-4F6E-B39C-231EE5712AE0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemEventFrame")]
	public class ApiResponsePIItemEventFrame : ApiParentResponse, IApiResponsePIItemEventFrame
	{
		public PIItemEventFrame Data { get; set; }
		public ApiResponsePIItemEventFrame(int statusCode, IDictionary<string, string> headers, PIItemEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

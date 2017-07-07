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
	[Guid("375F42BF-9A53-430F-8CC3-63C79BCAFA1E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElementTemplate
	{
		[DispId(1)]
		PIItemsElementTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("CF807EA4-8A2F-4319-9F4D-AA2ADC755967")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElementTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElementTemplate")]
	public class ApiResponsePIItemsElementTemplate : ApiParentResponse, IApiResponsePIItemsElementTemplate
	{
		public PIItemsElementTemplate Data { get; set; }
		public ApiResponsePIItemsElementTemplate(int statusCode, IDictionary<string, string> headers, PIItemsElementTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

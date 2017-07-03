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
	[Guid("31A8CB12-2A7E-4CC0-A336-5254C548B6F2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemElement
	{
		[DispId(1)]
		PIItemsItemElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F5D59F44-42CF-4FBD-887C-7DFB25263DD2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemElement")]
	public class ApiResponsePIItemsItemElement : ApiParentResponse, IApiResponsePIItemsItemElement
	{
		public PIItemsItemElement Data { get; set; }
		public ApiResponsePIItemsItemElement(int statusCode, IDictionary<string, string> headers, PIItemsItemElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

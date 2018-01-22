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
	[Guid("ED193E61-7C7D-48DE-935C-4EDD813000AA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeCategory
	{
		[DispId(1)]
		PIAttributeCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3C1BCC3E-8817-4326-BDA6-ABB121DF1E47")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeCategory")]
	public class ApiResponsePIAttributeCategory : ApiParentResponse, IApiResponsePIAttributeCategory
	{
		public PIAttributeCategory Data { get; set; }
		public ApiResponsePIAttributeCategory(int statusCode, IDictionary<string, string> headers, PIAttributeCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

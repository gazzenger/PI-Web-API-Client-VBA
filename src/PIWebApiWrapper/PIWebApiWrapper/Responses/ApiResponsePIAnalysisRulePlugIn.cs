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
	[Guid("6B38B65B-BF11-4740-938B-068F8926D88D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRulePlugIn
	{
		[DispId(1)]
		PIAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C2D9BD06-8E8C-4E4D-8C14-D2CA1E82CFA3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRulePlugIn")]
	public class ApiResponsePIAnalysisRulePlugIn : ApiParentResponse, IApiResponsePIAnalysisRulePlugIn
	{
		public PIAnalysisRulePlugIn Data { get; set; }
		public ApiResponsePIAnalysisRulePlugIn(int statusCode, IDictionary<string, string> headers, PIAnalysisRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}

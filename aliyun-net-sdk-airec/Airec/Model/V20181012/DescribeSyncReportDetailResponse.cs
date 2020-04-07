/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Airec.Model.V20181012
{
	public class DescribeSyncReportDetailResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<DescribeSyncReportDetail_ResultItem> result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<DescribeSyncReportDetail_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeSyncReportDetail_ResultItem
		{

			private string type;

			private float? errorPercent;

			private int? errorCount;

			private bool? defaultDisplay;

			private bool? sampleDisplay;

			private List<DescribeSyncReportDetail_HistoryDataItem> historyData;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public float? ErrorPercent
			{
				get
				{
					return errorPercent;
				}
				set	
				{
					errorPercent = value;
				}
			}

			public int? ErrorCount
			{
				get
				{
					return errorCount;
				}
				set	
				{
					errorCount = value;
				}
			}

			public bool? DefaultDisplay
			{
				get
				{
					return defaultDisplay;
				}
				set	
				{
					defaultDisplay = value;
				}
			}

			public bool? SampleDisplay
			{
				get
				{
					return sampleDisplay;
				}
				set	
				{
					sampleDisplay = value;
				}
			}

			public List<DescribeSyncReportDetail_HistoryDataItem> HistoryData
			{
				get
				{
					return historyData;
				}
				set	
				{
					historyData = value;
				}
			}

			public class DescribeSyncReportDetail_HistoryDataItem
			{

				private float? errorPercent;

				private long? startTime;

				private long? endTime;

				public float? ErrorPercent
				{
					get
					{
						return errorPercent;
					}
					set	
					{
						errorPercent = value;
					}
				}

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}
			}
		}
	}
}

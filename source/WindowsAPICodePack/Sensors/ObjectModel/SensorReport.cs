// Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.WindowsAPICodePack.Sensors
{
	/// <summary>Represents all the data from a single sensor data report.</summary>
	public class SensorReport
	{
		private Sensor originator;

		private SensorData sensorData;

		private DateTime timeStamp = new DateTime();

		/// <summary>Gets the sensor that is the source of this data report.</summary>
		public Sensor Source => originator;

		/// <summary>Gets the time when the data report was generated.</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TimeStamp")]
		public DateTime TimeStamp => timeStamp;

		/// <summary>Gets the data values in the report.</summary>
		public SensorData Values => sensorData;

		internal static SensorReport FromNativeReport(Sensor originator, ISensorDataReport iReport)
		{
			var systemTimeStamp = new SystemTime();
			iReport.GetTimestamp(out systemTimeStamp);
			var ftTimeStamp = new FILETIME();
			SensorNativeMethods.SystemTimeToFileTime(ref systemTimeStamp, out ftTimeStamp);
			var lTimeStamp = (((long)ftTimeStamp.dwHighDateTime) << 32) + ftTimeStamp.dwLowDateTime;
			var timeStamp = DateTime.FromFileTime(lTimeStamp);

			var sensorReport = new SensorReport
			{
				originator = originator,
				timeStamp = timeStamp,
				sensorData = SensorData.FromNativeReport(originator.internalObject, iReport)
			};

			return sensorReport;
		}
	}
}
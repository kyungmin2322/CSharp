﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
	public class Time
	{
		public static TimeSpan deltaTime;

		protected static DateTime currentTime;
		protected static DateTime lastTime;

		public static void Update()
		{
			currentTime = DateTime.Now;
			deltaTime = currentTime - lastTime;
			lastTime = currentTime;
		}
	}
}

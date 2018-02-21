﻿// ===============================================================================
// Alachisoft (R) NCache Sample Code.
// ===============================================================================
// Copyright © Alachisoft.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================

using System;

namespace Alachisoft.NCache.Samples
{
    /// ******************************************************************************
    /// <summary>
    /// A sample program that demonstrates how to use polling depenecy in NCache.
    /// 
    /// Requirements:
    ///     1. A running NCache cache
    ///     2. Connection attributes in app.config
    /// </summary>
	public class Program
	{
        /// <summary>
        /// The main entry point
        /// </summary>
        /// <param name="args"></param>
		public static void Main(string[] args)
		{
            try
            {
                Alachisoft.NCache.Samples.PollingDependency.Run();
			}
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
		}
	}
}
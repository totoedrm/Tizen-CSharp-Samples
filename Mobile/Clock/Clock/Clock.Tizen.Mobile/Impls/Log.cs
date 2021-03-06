﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#define PRINT_DEBUG
using Clock.Interfaces;
using Clock.Tizen.Mobile.Impls;
using Native = Tizen.Log;

[assembly: Xamarin.Forms.Dependency(typeof(Log))]

namespace Clock.Tizen.Mobile.Impls
{
    public class Log : ILog
    {
        public Log()
        {
        }

        public void Debug(string message, string file = "", string func = "", int line = 0)
        {
#if PRINT_DEBUG
            Native.Debug("ClockDotNet", message, file, func, line);
#endif
        }

        public void Error(string message, string file = "", string func = "", int line = 0)
        {
#if PRINT_DEBUG
            Native.Error("Clock#", message, file, func, line);
#endif
        }
    }
}

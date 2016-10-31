/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Applications.Notifications
{
    internal enum NotificationError
    {
        None = Tizen.Internals.Errors.ErrorCode.None,
        InvalidParameter = Tizen.Internals.Errors.ErrorCode.InvalidParameter,
        OutOfMemory = Tizen.Internals.Errors.ErrorCode.OutOfMemory,
        IoError = Tizen.Internals.Errors.ErrorCode.IoError,
        DbError = -0x01140000 | 0x01,
        AlreadyExists = -0x01140000 | 0x02,
        DBusError = -0x01140000 | 0x03,
        DoesnotExist = -0x01140000 | 0x04,
        ServiceError = -0x01140000 | 0x05,
        PermissionDenied = Tizen.Internals.Errors.ErrorCode.PermissionDenied,
        InvalidOperation = Tizen.Internals.Errors.ErrorCode.InvalidOperation
    }

    internal static class NotificationErrorFactory
    {
        private const string _logTag = "Tizen.Applications.Notification";

        internal static Exception GetException(NotificationError ret, string msg)
        {
            switch (ret)
            {
                case NotificationError.InvalidParameter:
                    Log.Error(_logTag, msg);
                    return new ArgumentException(ret + " error occurred.");
                default:
                    Log.Error(_logTag, msg);
                    return new InvalidOperationException(ret + " error occurred.");
            }
        }
    }
}

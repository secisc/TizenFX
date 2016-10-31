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
using System.Runtime.InteropServices;

using Tizen.Internals.Errors;
using Tizen.Applications;

internal static partial class Interop
{
    internal static partial class AppCommon
    {
        internal enum AppEventType
        {
            LowMemory = 0,
            LowBattery,
            LanguageChanged,
            DeviceOrientationChanged,
            RegionFormatChanged,
            SuspendedStateChanged
        }

        internal delegate void AppEventCallback(IntPtr handle, IntPtr data);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_id")]
        internal static extern ErrorCode AppGetId(out string appId);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_name")]
        internal static extern ErrorCode AppGetName(out string name);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_resource_path")]
        internal static extern string AppGetResourcePath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_data_path")]
        internal static extern string AppGetDataPath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_cache_path")]
        internal static extern string AppGetCachePath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_shared_data_path")]
        internal static extern string AppGetSharedDataPath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_shared_resource_path")]
        internal static extern string AppGetSharedResourcePath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_shared_trusted_path")]
        internal static extern string AppGetSharedTrustedPath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_tep_resource_path")]
        internal static extern string AppGetTepResourcePath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_external_cache_path")]
        internal static extern string AppGetExternalCachePath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_external_data_path")]
        internal static extern string AppGetExternalDataPath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_external_shared_data_path")]
        internal static extern string AppGetExternalSharedDataPath();

        [DllImport(Libraries.AppCommon, EntryPoint = "app_get_version")]
        internal static extern ErrorCode AppGetVersion(out string version);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_event_get_low_memory_status")]
        internal static extern ErrorCode AppEventGetLowMemoryStatus(IntPtr handle, out LowMemoryStatus status);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_event_get_low_battery_status")]
        internal static extern ErrorCode AppEventGetLowBatteryStatus(IntPtr handle, out LowBatteryStatus status);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_event_get_language")]
        internal static extern ErrorCode AppEventGetLanguage(IntPtr handle, out string lang);

        [DllImport(Libraries.AppCommon, EntryPoint = "app_event_get_region_format")]
        internal static extern ErrorCode AppEventGetRegionFormat(IntPtr handle, out string region);

    }
}


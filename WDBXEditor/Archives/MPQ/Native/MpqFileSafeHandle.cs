﻿using Microsoft.Win32.SafeHandles;
using System;

namespace WDBXEditor.Archives.MPQ.Native
{
    internal sealed class MpqFileSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public MpqFileSafeHandle(IntPtr handle)
            : base(true)
        {
            SetHandle(handle);
        }

        public MpqFileSafeHandle()
            : base(true)
        {
        }

        protected override bool ReleaseHandle()
        {
            return NativeMethods.SFileCloseFile(handle);
        }
    }
}

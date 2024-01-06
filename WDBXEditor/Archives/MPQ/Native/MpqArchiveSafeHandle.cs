using Microsoft.Win32.SafeHandles;
using System;

namespace WDBXEditor.Archives.MPQ.Native
{
    internal sealed class MpqArchiveSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public MpqArchiveSafeHandle(IntPtr handle)
            : base(true)
        {
            SetHandle(handle);
        }

        public MpqArchiveSafeHandle()
            : base(true) { }

        protected override bool ReleaseHandle()
        {
            return NativeMethods.SFileCloseArchive(handle);
        }
    }
}

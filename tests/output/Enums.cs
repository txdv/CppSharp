// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Wrappers {
    using System;
    using System.Runtime.InteropServices;
    using Mono.VisualC.Interop;
    
    public enum Callback {
        ConnectCallback = 0,
        DisconnectCallback = 1,
        AdoptCurrentThread = 2,
        EventNotifyCallback = 3,
        LastCallback = 4,
    }
    public enum InternalFunction {
        CreateThreadForAdoption = 0,
        RefAdoptedThread = 1,
        DerefAdoptedThread = 2,
        SetCurrentThreadToMainThread = 3,
        SetQObjectSender = 4,
        GetQObjectSender = 5,
        ResetQObjectSender = 6,
        LastInternalFunction = 7,
    }
    public enum GestureFlag {
        DontStartGestureOnChildren = 1,
        ReceivePartialGestures = 2,
    }
}
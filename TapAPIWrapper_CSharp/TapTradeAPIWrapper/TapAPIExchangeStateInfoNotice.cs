/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace TapTradeAPI {

using System;
using System.Runtime.InteropServices;

public class TapAPIExchangeStateInfoNotice : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIExchangeStateInfoNotice(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIExchangeStateInfoNotice obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIExchangeStateInfoNotice() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIExchangeStateInfoNotice(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public char IsLast {
    set {
      TapTradePINVOKE.TapAPIExchangeStateInfoNotice_IsLast_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIExchangeStateInfoNotice_IsLast_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIExchangeStateInfo ExchangeStateInfo {
    set {
      TapTradePINVOKE.TapAPIExchangeStateInfoNotice_ExchangeStateInfo_set(swigCPtr, TapAPIExchangeStateInfo.getCPtr(value));
    } 
    get {
      IntPtr cPtr = TapTradePINVOKE.TapAPIExchangeStateInfoNotice_ExchangeStateInfo_get(swigCPtr);
      TapAPIExchangeStateInfo ret = (cPtr == IntPtr.Zero) ? null : new TapAPIExchangeStateInfo(cPtr, false);
      return ret;
    } 
  }

  public TapAPIExchangeStateInfoNotice() : this(TapTradePINVOKE.new_TapAPIExchangeStateInfoNotice__SWIG_0(), true) {
  }

  public TapAPIExchangeStateInfoNotice(TapAPIExchangeStateInfoNotice other) : this(TapTradePINVOKE.new_TapAPIExchangeStateInfoNotice__SWIG_1(TapAPIExchangeStateInfoNotice.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}

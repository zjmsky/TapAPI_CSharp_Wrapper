/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace TapQuoteAPI {

using System;
using System.Runtime.InteropServices;

public class TapAPIQuotLoginRspInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuotLoginRspInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIQuotLoginRspInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuotLoginRspInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuotePINVOKE.delete_TapAPIQuotLoginRspInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginProt {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_set(swigCPtr, value);
    } 
    get {
      uint ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string InitTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_InitTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_InitTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIQuotLoginRspInfo() : this(TapQuotePINVOKE.new_TapAPIQuotLoginRspInfo__SWIG_0(), true) {
  }

  public TapAPIQuotLoginRspInfo(TapAPIQuotLoginRspInfo other) : this(TapQuotePINVOKE.new_TapAPIQuotLoginRspInfo__SWIG_1(TapAPIQuotLoginRspInfo.getCPtr(other)), true) {
    if (TapQuotePINVOKE.SWIGPendingException.Pending) throw TapQuotePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
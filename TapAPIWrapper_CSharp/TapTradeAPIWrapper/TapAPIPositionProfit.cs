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

public class TapAPIPositionProfit : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionProfit(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIPositionProfit obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIPositionProfit() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIPositionProfit(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string PositionNo {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_PositionNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIPositionProfit_PositionNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionStreamId {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_PositionStreamId_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradePINVOKE.TapAPIPositionProfit_PositionStreamId_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIPositionProfit_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEPositionProfit {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_LMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIPositionProfit_LMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIPositionProfit_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CalculatePrice {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_CalculatePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIPositionProfit_CalculatePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double FloatingPL {
    set {
      TapTradePINVOKE.TapAPIPositionProfit_FloatingPL_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIPositionProfit_FloatingPL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionProfit() : this(TapTradePINVOKE.new_TapAPIPositionProfit__SWIG_0(), true) {
  }

  public TapAPIPositionProfit(TapAPIPositionProfit other) : this(TapTradePINVOKE.new_TapAPIPositionProfit__SWIG_1(TapAPIPositionProfit.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}

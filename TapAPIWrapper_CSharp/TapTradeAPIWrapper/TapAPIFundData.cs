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

public class TapAPIFundData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFundData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIFundData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIFundData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradePINVOKE.delete_TapAPIFundData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradePINVOKE.TapAPIFundData_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIFundData_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      TapTradePINVOKE.TapAPIFundData_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIFundData_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradePINVOKE.TapAPIFundData_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIFundData_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradePINVOKE.TapAPIFundData_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradePINVOKE.TapAPIFundData_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeRate {
    set {
      TapTradePINVOKE.TapAPIFundData_TradeRate_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_TradeRate_get(swigCPtr);
      return ret;
    } 
  }

  public char FutureAlg {
    set {
      TapTradePINVOKE.TapAPIFundData_FutureAlg_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIFundData_FutureAlg_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionAlg {
    set {
      TapTradePINVOKE.TapAPIFundData_OptionAlg_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradePINVOKE.TapAPIFundData_OptionAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      TapTradePINVOKE.TapAPIFundData_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreUnExpProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_PreUnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreUnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreLMEPositionProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_PreLMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreLMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreEquity {
    set {
      TapTradePINVOKE.TapAPIFundData_PreEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double PreAvailable1 {
    set {
      TapTradePINVOKE.TapAPIFundData_PreAvailable1_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreAvailable1_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMarketEquity {
    set {
      TapTradePINVOKE.TapAPIFundData_PreMarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PreMarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double CashInValue {
    set {
      TapTradePINVOKE.TapAPIFundData_CashInValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CashInValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashOutValue {
    set {
      TapTradePINVOKE.TapAPIFundData_CashOutValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CashOutValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashAdjustValue {
    set {
      TapTradePINVOKE.TapAPIFundData_CashAdjustValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CashAdjustValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashPledged {
    set {
      TapTradePINVOKE.TapAPIFundData_CashPledged_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CashPledged_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenFee {
    set {
      TapTradePINVOKE.TapAPIFundData_FrozenFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_FrozenFee_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenDeposit {
    set {
      TapTradePINVOKE.TapAPIFundData_FrozenDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_FrozenDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFee {
    set {
      TapTradePINVOKE.TapAPIFundData_AccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_AccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeFee {
    set {
      TapTradePINVOKE.TapAPIFundData_ExchangeFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_ExchangeFee_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountDeliveryFee {
    set {
      TapTradePINVOKE.TapAPIFundData_AccountDeliveryFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_AccountDeliveryFee_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      TapTradePINVOKE.TapAPIFundData_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      TapTradePINVOKE.TapAPIFundData_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_DeliveryProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_DeliveryProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UnExpProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_UnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_UnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double ExpProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_ExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_ExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LmePositionProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_LmePositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_LmePositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      TapTradePINVOKE.TapAPIFundData_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountIntialMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_AccountIntialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_AccountIntialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitalMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_UpperInitalMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_UpperInitalMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Discount {
    set {
      TapTradePINVOKE.TapAPIFundData_Discount_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_Discount_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      TapTradePINVOKE.TapAPIFundData_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Equity {
    set {
      TapTradePINVOKE.TapAPIFundData_Equity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_Equity_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      TapTradePINVOKE.TapAPIFundData_Available_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double CanDraw {
    set {
      TapTradePINVOKE.TapAPIFundData_CanDraw_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_CanDraw_get(swigCPtr);
      return ret;
    } 
  }

  public double MarketEquity {
    set {
      TapTradePINVOKE.TapAPIFundData_MarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_MarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double OriginalCashInOut {
    set {
      TapTradePINVOKE.TapAPIFundData_OriginalCashInOut_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_OriginalCashInOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FloatingPL {
    set {
      TapTradePINVOKE.TapAPIFundData_FloatingPL_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_FloatingPL_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenRiskFundValue {
    set {
      TapTradePINVOKE.TapAPIFundData_FrozenRiskFundValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_FrozenRiskFundValue_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePL {
    set {
      TapTradePINVOKE.TapAPIFundData_ClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_ClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public double NoCurrencyPledgeValue {
    set {
      TapTradePINVOKE.TapAPIFundData_NoCurrencyPledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_NoCurrencyPledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double PrePledgeValue {
    set {
      TapTradePINVOKE.TapAPIFundData_PrePledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PrePledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeIn {
    set {
      TapTradePINVOKE.TapAPIFundData_PledgeIn_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PledgeIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeOut {
    set {
      TapTradePINVOKE.TapAPIFundData_PledgeOut_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PledgeOut_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeValue {
    set {
      TapTradePINVOKE.TapAPIFundData_PledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_PledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double BorrowValue {
    set {
      TapTradePINVOKE.TapAPIFundData_BorrowValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_BorrowValue_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFrozenMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountMargin {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialAccountMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialAccountMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFrozenFee {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialAccountFrozenFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialAccountFrozenFee_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFee {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialAccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialAccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialFloatProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialFloatProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialFloatProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialCloseProfit {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialCloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialFloatPL {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialFloatPL_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialFloatPL_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialClosePL {
    set {
      TapTradePINVOKE.TapAPIFundData_SpecialClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradePINVOKE.TapAPIFundData_SpecialClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFundData() : this(TapTradePINVOKE.new_TapAPIFundData__SWIG_0(), true) {
  }

  public TapAPIFundData(TapAPIFundData other) : this(TapTradePINVOKE.new_TapAPIFundData__SWIG_1(TapAPIFundData.getCPtr(other)), true) {
    if (TapTradePINVOKE.SWIGPendingException.Pending) throw TapTradePINVOKE.SWIGPendingException.Retrieve();
  }

}

}

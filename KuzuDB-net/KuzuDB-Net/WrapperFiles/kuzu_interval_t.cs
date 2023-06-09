//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace KuzuDB {

public class kuzu_interval_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal kuzu_interval_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(kuzu_interval_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(kuzu_interval_t obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~kuzu_interval_t() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          KuzuDBPINVOKE.delete_kuzu_interval_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_int32_t months {
    set {
      KuzuDBPINVOKE.kuzu_interval_t_months_set(swigCPtr, SWIGTYPE_p_int32_t.getCPtr(value));
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(KuzuDBPINVOKE.kuzu_interval_t_months_get(swigCPtr), true);
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int32_t days {
    set {
      KuzuDBPINVOKE.kuzu_interval_t_days_set(swigCPtr, SWIGTYPE_p_int32_t.getCPtr(value));
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int32_t ret = new SWIGTYPE_p_int32_t(KuzuDBPINVOKE.kuzu_interval_t_days_get(swigCPtr), true);
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int64_t micros {
    set {
      KuzuDBPINVOKE.kuzu_interval_t_micros_set(swigCPtr, SWIGTYPE_p_int64_t.getCPtr(value));
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_int64_t ret = new SWIGTYPE_p_int64_t(KuzuDBPINVOKE.kuzu_interval_t_micros_get(swigCPtr), true);
      if (KuzuDBPINVOKE.SWIGPendingException.Pending) throw KuzuDBPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public kuzu_interval_t() : this(KuzuDBPINVOKE.new_kuzu_interval_t(), true) {
  }

}

}
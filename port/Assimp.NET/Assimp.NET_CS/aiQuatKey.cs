/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiQuatKey : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiQuatKey(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiQuatKey obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiQuatKey() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiQuatKey(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public double mTime {
    set {
      AssimpPINVOKE.aiQuatKey_mTime_set(swigCPtr, value);
    } 
    get {
      double ret = AssimpPINVOKE.aiQuatKey_mTime_get(swigCPtr);
      return ret;
    } 
  }

  public aiQuaternion mValue {
    set {
      AssimpPINVOKE.aiQuatKey_mValue_set(swigCPtr, aiQuaternion.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiQuatKey_mValue_get(swigCPtr);
      aiQuaternion ret = (cPtr == IntPtr.Zero) ? null : new aiQuaternion(cPtr, false);
      return ret;
    } 
  }

  public aiQuatKey() : this(AssimpPINVOKE.new_aiQuatKey__SWIG_0(), true) {
  }

  public aiQuatKey(double time, aiQuaternion value) : this(AssimpPINVOKE.new_aiQuatKey__SWIG_1(time, aiQuaternion.getCPtr(value)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool __equal__(aiQuatKey o) {
    bool ret = AssimpPINVOKE.aiQuatKey___equal__(swigCPtr, aiQuatKey.getCPtr(o));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __nequal__(aiQuatKey o) {
    bool ret = AssimpPINVOKE.aiQuatKey___nequal__(swigCPtr, aiQuatKey.getCPtr(o));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __smaller__(aiQuatKey o) {
    bool ret = AssimpPINVOKE.aiQuatKey___smaller__(swigCPtr, aiQuatKey.getCPtr(o));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __greater__(aiQuatKey o) {
    bool ret = AssimpPINVOKE.aiQuatKey___greater__(swigCPtr, aiQuatKey.getCPtr(o));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

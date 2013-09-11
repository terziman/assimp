/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiColor4DVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<aiColor4D>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiColor4DVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiColor4DVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiColor4DVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiColor4DVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiColor4DVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (aiColor4D element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public aiColor4D this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(aiColor4D[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(aiColor4D[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, aiColor4D[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<aiColor4D> System.Collections.Generic.IEnumerable<aiColor4D>.GetEnumerator() {
    return new aiColor4DVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new aiColor4DVectorEnumerator(this);
  }

  public aiColor4DVectorEnumerator GetEnumerator() {
    return new aiColor4DVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class aiColor4DVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<aiColor4D>
#endif
  {
    private aiColor4DVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public aiColor4DVectorEnumerator(aiColor4DVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public aiColor4D Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (aiColor4D)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    AssimpPINVOKE.aiColor4DVector_Clear(swigCPtr);
  }

  public void Add(aiColor4D x) {
    AssimpPINVOKE.aiColor4DVector_Add(swigCPtr, aiColor4D.getCPtr(x));
  }

  private uint size() {
    uint ret = AssimpPINVOKE.aiColor4DVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = AssimpPINVOKE.aiColor4DVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    AssimpPINVOKE.aiColor4DVector_reserve(swigCPtr, n);
  }

  public aiColor4DVector() : this(AssimpPINVOKE.new_aiColor4DVector__SWIG_0(), true) {
  }

  public aiColor4DVector(aiColor4DVector other) : this(AssimpPINVOKE.new_aiColor4DVector__SWIG_1(aiColor4DVector.getCPtr(other)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiColor4DVector(int capacity) : this(AssimpPINVOKE.new_aiColor4DVector__SWIG_2(capacity), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  private aiColor4D getitemcopy(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiColor4DVector_getitemcopy(swigCPtr, index);
    aiColor4D ret = (cPtr == IntPtr.Zero) ? null : new aiColor4D(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private aiColor4D getitem(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiColor4DVector_getitem(swigCPtr, index);
    aiColor4D ret = (cPtr == IntPtr.Zero) ? null : new aiColor4D(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, aiColor4D val) {
    AssimpPINVOKE.aiColor4DVector_setitem(swigCPtr, index, aiColor4D.getCPtr(val));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(aiColor4DVector values) {
    AssimpPINVOKE.aiColor4DVector_AddRange(swigCPtr, aiColor4DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiColor4DVector GetRange(int index, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiColor4DVector_GetRange(swigCPtr, index, count);
    aiColor4DVector ret = (cPtr == IntPtr.Zero) ? null : new aiColor4DVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, aiColor4D x) {
    AssimpPINVOKE.aiColor4DVector_Insert(swigCPtr, index, aiColor4D.getCPtr(x));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, aiColor4DVector values) {
    AssimpPINVOKE.aiColor4DVector_InsertRange(swigCPtr, index, aiColor4DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    AssimpPINVOKE.aiColor4DVector_RemoveAt(swigCPtr, index);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    AssimpPINVOKE.aiColor4DVector_RemoveRange(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static aiColor4DVector Repeat(aiColor4D value, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiColor4DVector_Repeat(aiColor4D.getCPtr(value), count);
    aiColor4DVector ret = (cPtr == IntPtr.Zero) ? null : new aiColor4DVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    AssimpPINVOKE.aiColor4DVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    AssimpPINVOKE.aiColor4DVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, aiColor4DVector values) {
    AssimpPINVOKE.aiColor4DVector_SetRange(swigCPtr, index, aiColor4DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(aiColor4D value) {
    bool ret = AssimpPINVOKE.aiColor4DVector_Contains(swigCPtr, aiColor4D.getCPtr(value));
    return ret;
  }

  public int IndexOf(aiColor4D value) {
    int ret = AssimpPINVOKE.aiColor4DVector_IndexOf(swigCPtr, aiColor4D.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(aiColor4D value) {
    int ret = AssimpPINVOKE.aiColor4DVector_LastIndexOf(swigCPtr, aiColor4D.getCPtr(value));
    return ret;
  }

  public bool Remove(aiColor4D value) {
    bool ret = AssimpPINVOKE.aiColor4DVector_Remove(swigCPtr, aiColor4D.getCPtr(value));
    return ret;
  }

}

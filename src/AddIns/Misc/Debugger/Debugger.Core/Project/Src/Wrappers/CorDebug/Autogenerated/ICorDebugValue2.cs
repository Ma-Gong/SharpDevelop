// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public partial class ICorDebugValue2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugValue2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugValue2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugValue2(Debugger.Interop.CorDebug.ICorDebugValue2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugValue2));
		}
		
		public static ICorDebugValue2 Wrap(Debugger.Interop.CorDebug.ICorDebugValue2 objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugValue2(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugValue2()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugValue2));
		}
		
		public bool Is<T>() where T: class
		{
			try {
				CastTo<T>();
				return true;
			} catch {
				return false;
			}
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugValue2 o1, ICorDebugValue2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugValue2 o1, ICorDebugValue2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugValue2 casted = o as ICorDebugValue2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public ICorDebugType ExactType
		{
			get
			{
				ICorDebugType ppType;
				Debugger.Interop.CorDebug.ICorDebugType out_ppType;
				this.WrappedObject.GetExactType(out out_ppType);
				ppType = ICorDebugType.Wrap(out_ppType);
				return ppType;
			}
		}
	}
}

#pragma warning restore 1591

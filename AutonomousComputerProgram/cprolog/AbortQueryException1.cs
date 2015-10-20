using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace AutonomousComputerProgram.CProlog
{
    [SerializableAttribute]
    public class AbortQueryException : System.ApplicationException
    {
        public AbortQueryException() { return; }
        [SerializableAttribute]
        public class ApplicationException : System.Exception
        {
            public ApplicationException() { return; }
            public ApplicationException(string message) { return; }
            public ApplicationException(string message, System.Exception innerException) { return; }
            public ApplicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { return  ;  }
            
            public class Exception
            {
                public Exception() { }
                public Exception(string message) { return; }
                public Exception(string message, System.Exception innerException) { return; }
                protected Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
                public virtual System.Exception GetBaseException() { return GetBaseException(); }
                public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
                public new System.Type GetType() { return null; }
                public override string ToString() { return ("message"); }
                public virtual System.Collections.IDictionary Data { get; }
                public virtual string HelpLink { get; set; }
                public int HResult { get; protected set; }
                public System.Exception InnerException { get; }
                public virtual string Message { get; }
                public virtual string Source { get; set; }
                public virtual string StackTrace { get; }
                public System.Reflection.MethodBase TargetSite { get; }
                protected event System.EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
                public interface _Exception
                {
                    bool Equals(object obj);// { return true; }
                    System.Exception GetBaseException();// { return GetBaseException(); }
                    int GetHashCode();// { return 1; }
                    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    System.Type GetType();
                    string ToString();// { return ""; }
                    string HelpLink { get; set; }
                    System.Exception InnerException { get; }
                    string Message { get; }
                    string Source { get; set; }
                    string StackTrace { get; }
                    System.Reflection.MethodBase TargetSite { get; }
                }
                public interface ISerializable
                {
                    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                }
                public class Object
                {
#if Debug
                    ~Object() { Debug.Fail("Finalizer called!"); }
#endif
                    public new  virtual bool Equals(object obj) { return (true); }
                    public new  static bool Equals(object objA, object objB) { return (true); }
                    public new  virtual int GetHashCode() { return (1); }
                    public new  System.Type GetType() { return null; }
                    protected new  object MemberwiseClone() { return (true); }
                    public Object() { }
                    public new static bool ReferenceEquals(object objA, object objB) { return (true); }
                    public new virtual string ToString() { return (""); }
                }
            }
        }
    }
}

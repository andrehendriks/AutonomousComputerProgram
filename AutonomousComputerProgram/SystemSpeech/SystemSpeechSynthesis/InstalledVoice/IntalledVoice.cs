using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace AutonomousComputerProgram.SystemSpeech.SystemSpeechSynthesis.InstalledVoice
{
    public class IntalledVoice
    {
        public override bool Equals(object obj) { return true; }
        public override int GetHashCode() { return 0; }
        public bool Enabled { get; set; }
        public System.Speech.Synthesis.VoiceInfo VoiceInfo { get; }
        public class Object
        {
#if Debug
            ~Object()
            {
                Debug.Fail("Finalizer called!");
            }
#endif
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            //public extern System.Type GetType();
            protected new object MemberwiseClone() { return true; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("*"); }
        }
    }
}

using System;
using System.Text;
using System.Threading;

namespace Events
{
    internal class videoEncoder
    {
        public delegate void doit();
        public event doit myevent;
        internal void EncodingVideo()
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(3000);
            onEncoded();
        }
        internal void onEncoded()
        {
            if (myevent != null)
                myevent();
        }
    }
}
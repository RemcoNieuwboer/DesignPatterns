using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Proxy
{
    public class VirtualProxy : ISubject
    {
        private RealSubject _subject;
        public string DoAction()
        {
            _subject = new RealSubject();
            return "Virtual Proxy: Call to " + _subject.DoAction();
        }
    }
}
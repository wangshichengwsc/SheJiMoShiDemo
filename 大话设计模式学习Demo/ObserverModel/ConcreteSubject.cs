﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel
{
    /// <summary>
    /// 通知者1
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string subjectState;
        public string SubjectState {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}

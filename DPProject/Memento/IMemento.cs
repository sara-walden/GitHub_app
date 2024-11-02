﻿using DPProject.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.Memento
{
    internal interface IMemento
    {
        
        string GetName();
        ItemContext GetLastState();
        DateTime GetDate();
    }
}

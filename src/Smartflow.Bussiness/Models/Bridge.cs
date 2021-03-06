﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow.Bussiness.Models
{
    public class Bridge
    {
        public virtual string InstanceID
        {
            get;
            set;
        }

        public virtual string CategoryCode
        {
            get;
            set;
        }

        public virtual string Key
        {
            get;
            set;
        }

        public virtual string Comment
        {
            get; set;
        }

        public virtual string Creator
        {
            get;
            set;
        }

        public virtual DateTime CreateTime
        {
            get;
            set;
        }
    }
}

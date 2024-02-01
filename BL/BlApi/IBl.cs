﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl;
using DalApi;
using BO;

   

public interface IBl
{
    public ITask task { get; }  // this is the interface of the BL layer that is used to implement the BL layer  functions of the Task
    public IEngineer engineer { get; } // this is the interface of the BL layer that is used to implement the BL layer  functions of the Engineer

    // public BO.IDependency dependency { get; }

}

﻿using UnityEngine;
using System.Collections;
using XLua;

namespace CatLib.Contracts.Base
{

    [LuaCallCSharp]
    public interface IBootstrap
    {

        void Bootstrap();

    }
}

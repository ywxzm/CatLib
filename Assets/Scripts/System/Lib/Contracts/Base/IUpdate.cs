﻿using UnityEngine;
using System.Collections;
using XLua;

namespace CatLib.Contracts.Base
{
    [LuaCallCSharp]
    ///<summary>刷新接口</summary>
    public interface IUpdate
    {

        void Update();

    }

}
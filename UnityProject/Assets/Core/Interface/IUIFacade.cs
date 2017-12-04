﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Sprites;
using UnityEngine.Scripting;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Assertions.Must;
using UnityEngine.Assertions.Comparers;
using System.Collections;
using System.Collections.Generic;
using BridgeUI.Model;

namespace BridgeUI
{
    public interface IUIFacade
    {
        IUIHandle Open(string panelName, object data = null);
        IUIHandle Open(string panelName, UnityAction<object> callBack, object data = null);
        bool IsPanelOpen(string panelName);
        void Hide(string panelName);
        void Close(string panelName);
    }
}
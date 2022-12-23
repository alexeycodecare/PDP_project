using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

namespace JS_Manager {
  public class JSManager
  {
    [DllImport("__Internal")]
    private static extern void JS_Died();

    [DllImport("__Internal")]
    private static extern void JS_Restart();

    public static void JS_PlayerDead() {
      if (Application.platform == RuntimePlatform.WebGLPlayer) {
        JS_Died();
      }
    }

    public static void JS_PlayerRestart() {
      if (Application.platform == RuntimePlatform.WebGLPlayer) {
        JS_Restart();
      }
    }
    
  }
  
}

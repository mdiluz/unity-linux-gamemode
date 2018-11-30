using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class LinuxGameMode : MonoBehaviour
{
#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
    [DllImport("UnityGameMode")]
    private static extern int UnityEnterGameMode();
    [DllImport("UnityGameMode")]
    private static extern int UnityExitGameMode();
#endif
    
    private void Start()
    {
#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
        UnityEnterGameMode();
#endif
    }
    
    private void End()
    {
#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
        UnityExitGameMode();
#endif
    }
}

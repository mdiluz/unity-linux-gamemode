using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class LinuxGameMode : MonoBehaviour
{
#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
    
    // Import functions from native lib
    [DllImport("UnityGameMode")]
    public static extern int GameModeRequestStart();
    [DllImport("UnityGameMode")]
    public static extern int GameModeRequestEnd();
    [DllImport("UnityGameMode")]
    public static extern int GameModeQueryStatus();
    
    private void Start()
    {
        Debug.Log("Requesting Linux GameMode Start");
        var ret = GameModeRequestStart();
        if (ret != 0)
        {
            Debug.Log($"Linux GameMode Start Failed: #{ret}");
        }
    }
    
    private void OnApplicationQuit()
    {
        Debug.Log("Requesting Linux GameMode End");
        var ret = GameModeRequestEnd();
        if (ret != 0)
        {
            Debug.Log($"Linux GameMode End failed: #{ret}");
        }
    }
#else
    public static int GameModeRequestStart() { return 0; }
    public static int GameModeRequestEnd() { return 0; }
    public static int GameModeQueryStatus() { return 0; }
#endif // UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
}

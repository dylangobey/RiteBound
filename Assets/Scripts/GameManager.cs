using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Process process;

    public static GameManager instance;

    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    private void OnApplicationQuit()
    {
        if(!Application.isEditor) process.Kill();
    }
}

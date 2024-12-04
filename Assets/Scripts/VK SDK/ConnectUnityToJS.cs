using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ConnectUnityToJS : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void UnityPluginRequestJs();

    // end of sdk

    [SerializeField] private GameManager _gameManager;

    public void RequestJS()
    {
        UnityPluginRequestJs();
    }

    public void ResponseOk()
    {
        _gameManager.ResponseFromJsOk();
    }
    public void ResponseError()
    {
        _gameManager.ResponseFromJsError();
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("JS")]
    [SerializeField] private ConnectUnityToJS _connector;

    [Header("UI")]
    [SerializeField] private Button _button;
    [SerializeField] private Image _buttonImage;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    public void ResponseFromJsOk()
    {
        _buttonImage.color = Color.green;
    }

    public void ResponseFromJsError()
    {
        _buttonImage.color = Color.red;
    }

    private void OnButtonClicked()
    {
        _connector.RequestJS();

        _buttonImage.color = Color.yellow;
    }
}

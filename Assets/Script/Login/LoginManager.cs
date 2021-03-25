using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    [SerializeField] private Button m_BtnLogin = null;
    
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        if (m_BtnLogin != null)
        {
            m_BtnLogin.onClick.AddListener(OnClick);
        }
    }

    public void OnClick()
    {
        Debug.Log("OnClick");
    }
}

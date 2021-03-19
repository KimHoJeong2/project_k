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
            Debug.Log(m_BtnLogin);
            Debug.LogError(m_BtnLogin.onClick.GetPersistentEventCount());


            m_BtnLogin.onClick.AddListener(OnClick);
            Debug.LogError(m_BtnLogin.onClick.GetPersistentEventCount());

            //m_BtnLogin.onClick.RemoveAllListeners();
            //Debug.LogError(m_BtnLogin.onClick.GetPersistentEventCount());

            //m_BtnLogin.onClick.AddListener(OnClick);
            //Debug.LogError(m_BtnLogin.onClick.GetPersistentEventCount());

            //m_BtnLogin.onClick.RemoveListener(OnClick);
            //Debug.LogError(m_BtnLogin.onClick.GetPersistentEventCount());
        }
    }

    public void OnClick()
    {
        Debug.LogError("OnClick");
    }
}

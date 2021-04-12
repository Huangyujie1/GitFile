using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using System;

/// <summary>
/// vive手柄控制器
/// </summary>
public class ViveHandController : MonoBehaviour
{
    
    [SerializeField]
    private HandRole handRole;
    /// <summary>
    /// 设置左右手
    /// </summary>
    private void SetHandRole()
    {
        ViveRoleSetter setter = GetComponent<ViveRoleSetter>();
        handRole = setter.viveRole.ToRole<HandRole>();
    }
    /// <summary>
    /// app退出
    /// </summary>
    private void AppQuit()
    {
        int index = ViveInput.ClickCount(handRole, ControllerButton.Menu);
        if (index >= 2)
        {
            Application.Quit();
        }
    }

    #region MonoBehaviour
    void Awake()
    {
        SetHandRole();
        //双击菜单键退出app
        ViveInput.AddClick(handRole, ControllerButton.Menu, AppQuit);
        //ViveInput.clickInterval = 1;

    }
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
    #endregion
}

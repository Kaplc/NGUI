using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePanel<T> : MonoBehaviour where T : class
{
    private T instance;

    public T Instance => instance;

    private void Start()
    {
        // 自动进行初始化
        Init();
    }
    
    // 方便子类初始化
    public abstract void Init();

    private void Awake()
    {
        instance = this as T;
    }

    public virtual void Show()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }
}
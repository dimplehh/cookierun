using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    [SerializeField]
    protected Define.State _state = Define.State.Idle;
    public virtual Define.State State
    {
        get { return _state; }
    }
    private void Start()
    {
        Init();
    }
    void Update()
    {
    }
    public abstract void Init();
}
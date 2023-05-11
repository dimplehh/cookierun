using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    public override void Init()
    {
        Managers.Input.MouseAction -= OnMouseEvent;
        Managers.Input.MouseAction += OnMouseEvent;
    }

    void OnMouseEvent(Define.MouseEvent evt)
    {
        switch(State)
        {

        }
    }
}

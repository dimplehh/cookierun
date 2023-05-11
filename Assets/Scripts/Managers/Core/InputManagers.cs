using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManagers
{
    public Action KeyAction = null; //리스너패턴
    public Action<Define.MouseEvent> MouseAction = null;

    bool _pressed = false;
    float _pressedTime = 0;
    public void OnUpdate()
    {
        if (Input.anyKey && KeyAction != null)
            KeyAction.Invoke();

        if(MouseAction != null)
        {
            if(Input.GetMouseButton(0))//마우스 왼버튼클릭
            {
                if(!_pressed)
                {
                    MouseAction.Invoke(Define.MouseEvent.PointerDown);
                    _pressedTime = Time.time;
                }
                MouseAction.Invoke(Define.MouseEvent.Press);
                _pressed = true;
            }
            else
            {
                if(_pressed)
                {
                    if (Time.time <= _pressedTime + 0.2f)
                        MouseAction.Invoke(Define.MouseEvent.Click);
                }
            }
        }
    }
}

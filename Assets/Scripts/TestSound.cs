using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound:MonoBehaviour
{
    int i = 0;
    public void startPlay()
    {
        if (i % 2 == 0)
            Managers.Sound.Play("bgm_lobby", Define.Sound.Bgm);
        else
            Managers.Sound.Play("bgm_main", Define.Sound.Bgm);
        i++;
    }
}

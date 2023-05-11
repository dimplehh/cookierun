using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers Instance { get { init(); return s_instance; } }
    #region Contents
    GameManager _game = new GameManager();
    public static GameManager Game { get { return Instance._game; } }
    #endregion
    #region Core
    InputManagers _input = new InputManagers();
    SoundManager _sound = new SoundManager();
    ResourceManager _resource = new ResourceManager();
    PoolManager _pool = new PoolManager();
    SceneManager _scene = new SceneManager();
    public static InputManagers Input { get { return Instance._input; } }
    public static SoundManager Sound { get { return Instance._sound; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static PoolManager Pool { get { return Instance._pool; } }
    public static SceneManager Scene { get { return Instance._scene; } }
    #endregion
    void Start()
    {
        init();
    }

    void Update()
    {
        _input.OnUpdate();
    }

    static void init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

            //s_instance._data.Init();
            //s_instance._pool.Init();
            s_instance._sound.Init();
        }
    }

    public static void Clear()
    {
        //data는
        //이 바뀌더라도 클리어할 필요 없고 안하는게 좋기때문에 clear x
        //Input.Clear();
        Sound.Clear();
        //UI.Clear();
        Scene.Clear();
        Pool.Clear();
    }
}

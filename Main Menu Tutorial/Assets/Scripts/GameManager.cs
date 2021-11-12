using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static float sensitvity = 1f, audioVol = 1f;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        GameObject[] _objs = GameObject.FindGameObjectsWithTag("GM");
        if (_objs.Length > 1)
        {
            Destroy(this.gameObject);
        } else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject []levels;
    #region Singleton
    public static Levels instance = null;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [HideInInspector] public Transform target;
    private Vector3 distance;

    #region Singleton
    public static CameraController instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    #endregion
    void Start()
    {
        if (target != null)
        {
            distance = target.position - transform.position;
        }
    }
    void Update()
    {
        if (target == null) return;
        transform.position = target.position - distance;  
    }
}

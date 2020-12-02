using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameStart : MonoBehaviour
{

    public Button start;
    // Update is called once per frame
    void Start()
    {
        start.transform.DOScale(1.2f, 1f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
    }
}



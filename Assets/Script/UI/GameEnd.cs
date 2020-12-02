using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text gameOverText;
    public Text successText;
    void Start()
    {
        gameOverText.DOColor(Color.red,0.3f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        gameOverText.DOFade(15, 0.7f);

        successText.DOColor(Color.green, 0.3f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

}

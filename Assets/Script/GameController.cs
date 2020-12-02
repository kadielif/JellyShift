using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject scaleCube;
    public int level;
    public GameObject levelPos;

    #region Singleton
    public static GameController instance = null;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    #endregion

    void Start()
    {
        level = PlayerPrefs.GetInt("level", 0);
        GetLevel();
    }
   
    public void StartGame()
    {
        Instantiate(scaleCube, scaleCube.transform.position, scaleCube.transform.rotation);
        CameraController.instance.target = GameObject.Find("ScalingCube(Clone)").transform;
        UIManager.instance.isStart = true;
    }
    public void LevelUp()
    {
        PlayerPrefs.SetInt("level", ++level);
        GetLevel();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GetLevel()
    {
        Instantiate(Levels.instance.levels[level], Levels.instance.levels[level].transform.position, Levels.instance.levels[level].transform.rotation,levelPos.transform);
    }


}



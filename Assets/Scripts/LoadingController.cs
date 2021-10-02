using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadingController : MonoBehaviour
{
    private void Start()
    {
        UserDataManager.Load();
        SceneManager.LoadScene(1);
    }
}

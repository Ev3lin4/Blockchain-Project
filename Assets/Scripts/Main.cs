using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Lifecycle 
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            string Scene = "GameUi";
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Lifecycle.Ui 
{
    public class GameUi : MonoBehaviour
    {
        public Button cube; 
        public Button exit;
        public Button sphere;
        public Button animations; 
        public Button blockchain;

        private void Awake()
        {
            cube.onClick.AddListener(Cube);
            exit.onClick.AddListener(Exit);
            sphere.onClick.AddListener(Sphere);
            animations.onClick.AddListener(Animations);
            blockchain.onClick.AddListener(Blockchain);       
            exit.gameObject.SetActive(false);     
        }

        private void Cube() 
        {
            //Debug.Log("Cube");
            string Scene = "Cube";
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
            animations.gameObject.SetActive(false);
            sphere.gameObject.SetActive(false);
            exit.gameObject.SetActive(true);
            cube.gameObject.SetActive(false);
            blockchain.gameObject.SetActive(false);

        }
        private void Exit()
        {
            int getSceneIndex = SceneManager.sceneCount -1;
            Scene scene = SceneManager.GetSceneAt(getSceneIndex);
            SceneManager.UnloadSceneAsync(scene);
            animations.gameObject.SetActive(true);
            sphere.gameObject.SetActive(true);
            exit.gameObject.SetActive(false);
            cube.gameObject.SetActive(true);
            blockchain.gameObject.SetActive(true);
        } 

        private void Sphere()
        {
            string Scene = "Sphere";
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
            animations.gameObject.SetActive(false);
            sphere.gameObject.SetActive(false);
            exit.gameObject.SetActive(true);
            cube.gameObject.SetActive(false);
            blockchain.gameObject.SetActive(false);
        }

        private void Animations()
        {
            string Scene = "Animations";
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
            animations.gameObject.SetActive(false);
            sphere.gameObject.SetActive(false);
            exit.gameObject.SetActive(true);
            cube.gameObject.SetActive(false);
            blockchain.gameObject.SetActive(false);
        }

        private void Blockchain()
        {
            string Scene = "Blockchain";
            SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
            blockchain.gameObject.SetActive(false);
            animations.gameObject.SetActive(false);
            sphere.gameObject.SetActive(false);
            exit.gameObject.SetActive(true);
            cube.gameObject.SetActive(false);

        }
    }
}
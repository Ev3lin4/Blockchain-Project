using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lifecycle.World 
{
    public class Cube : MonoBehaviour
    {
        private Quaternion randomRotationDirection;

        // Start is called before the first frame update
        private void Awake()
        {
            randomRotationDirection = Random.rotation;
            //randomRotationDirection = new Quaternion(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(randomRotationDirection.eulerAngles * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                randomRotationDirection = Random.rotation;
            }
        }
    }
}


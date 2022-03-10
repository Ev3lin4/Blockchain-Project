using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lifecycle.World 
{
    public class Sphere : MonoBehaviour
    {
        public MeshRenderer sphereMeshRenderer;
        public Rigidbody sphereRigidBody; 

        // Start is called before the first frame update
        private void Awake()
        {
           sphereMeshRenderer.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C)) 
            {
                sphereMeshRenderer.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                sphereRigidBody.AddForce(0, 4, 0, ForceMode.Impulse);
                //sphereRigidBody.AddForce(Vector3.up);
            }
        }
    }
}
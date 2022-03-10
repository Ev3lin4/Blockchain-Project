using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lifecycle.World 
{
    public class Animations : MonoBehaviour
    {
        public Animator animator;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                animator.Play("BasicMotionsDummy");
            }

               //Debug.Log(this.transform.FindChild("BasicMotionsDummy"));
                // animationController.Random = Random.Range(1, 4);
                 /* anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }*/
        }
    }
}
//On Update() make it listen to KeyCode.Space so everytime the player presses "space" makes the animationController play a random animation 

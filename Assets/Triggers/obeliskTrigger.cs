using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obeliskTrigger : MonoBehaviour
{
    private Animator mAnimator;
   
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        
        mAnimator.SetTrigger("obeliskTrigger");
    }

    private void OnTriggerExit(Collider other)
    {
 
    }

    private void OnTriggerStay(Collider other)
    {
   
    }
}

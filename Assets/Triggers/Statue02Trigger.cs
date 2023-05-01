using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue02Trigger : MonoBehaviour
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
        Debug.Log("statueTrigerToMove");
        mAnimator.SetTrigger("statueTrigerToMove");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("statueTrigerToMove");
        Debug.Log("out");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("statueTrigerToMove");
    }
}

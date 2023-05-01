using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateTrigger : MonoBehaviour
{
    private Animator mAnimator;
    public AudioSource playSound;
   
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
        Debug.Log("enter");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("out");
        playSound.Play();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("gateOpen");
            mAnimator.SetTrigger("GtOpen");
        }
    }
}

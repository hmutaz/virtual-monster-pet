using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerer : MonoBehaviour
{
    public GameObject Pet;
    
    public void OnClick()
    {
        Pet.GetComponent<Animator>().Play("Tapped", 0);
    }
}

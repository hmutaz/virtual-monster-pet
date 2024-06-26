using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    public GameObject foxMonster;
    public GameObject canMonster;

    // Start is called before the first frame update
    void Start()
    {
        switch (MonsterStateController.monsterState)
        {
            case 1:
                canMonster.SetActive(true);
                foxMonster.SetActive(false);
                break;
            default:
                foxMonster.SetActive(true);
                canMonster.SetActive(false);
                break;
        }
    }
}

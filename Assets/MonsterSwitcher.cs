using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonsterSwitcher : MonoBehaviour
{
    public TMP_Text monsterText;
    public static int monsterState = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMonster();
    }

    public void OnSwitch()
    {
        if (monsterState == 0)
        {
            monsterState = 1;
        }
        else
        {
            monsterState = 0;
        }
        UpdateMonster();
    }

    public void UpdateMonster()
    {
        MonsterStateController.monsterState = monsterState;
        switch (monsterState)
        {
            case 1:
                monsterText.text = "Can Monster";
                break;
            default:
                monsterText.text = "Fox Spirit";
                break;
        }
    }
}

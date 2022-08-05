using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int live = 1;

    public void Healing(int value)
    {
        live += value;
    }

}

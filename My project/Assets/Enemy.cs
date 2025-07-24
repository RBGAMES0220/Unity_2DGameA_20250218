using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private SpriteRenderer sr;

   [SerializeField] private float redColorDuration = 1;

    public float currentTimeInGame;
    public float lastTimeWasDamage;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        currentTimeInGame = Time.time;

        if (currentTimeInGame > lastTimeWasDamage + redColorDuration)
        {
            if (sr.color != Color.white)
            {
                sr.color = Color.white;
            }
        }
    }

    [ContextMenu("Update timer")]

    

    public void TakeDamage()
    {
        sr.color = Color.red;
        lastTimeWasDamage = Time.time;
    }

    private void TurnWhite()
    {
        sr.color = Color.white;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    //최대 능력치
    public int MaxElec = 100;
    public int MaxHappy = 100;
    public int MaxArmor = 100;

    //현재 능력치
    public int Elec = 100;
    public int Happy = 100;
    public int Armor = 100;

    bool isDie = false;
    bool Charac = true;

    GameObject player;

    void Awake()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(this.player);
        if(this.player != null)
        {
            Destroy(this.player);
        }
    }

    void Start()
    {
        Elec = MaxElec;
        Happy = MaxHappy;
        Armor = MaxArmor;
        PInv();
    }

    void Update()
    {
        if (Elec == 0)
        {
            if (!isDie)
                Die();
        }
    }

    void Die()
    {
        isDie = true;
        Invoke("GoTitle", 2.0f);
    }

    void PInv()
    {
        InvokeRepeating("ElecDown", 3.0f, 3.0f);
    }

    void ElecDown()
    {
        Elec -= 10;
        Debug.Log("----");
    }

    void GoTitle()
    {
        ManagerClass.instance.ReStart();
    }
}

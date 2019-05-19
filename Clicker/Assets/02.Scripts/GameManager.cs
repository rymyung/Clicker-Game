using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public static long money;

    private void Awake() {
        gm = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        earnMoney();
    }

    public void earnMoney() {
        if (Input.GetMouseButtonDown(0)) {
            money += 1;
            Debug.Log(money);
        }
    }
}

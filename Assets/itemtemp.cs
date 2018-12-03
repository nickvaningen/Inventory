using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemtemp : MonoBehaviour {

    public override void Use()
    {
        print("used");
    }

    public override void Drop(int amount)
    {
        print("let go of:" + amount);
        //Destroy(this.gameObject);
    }
}

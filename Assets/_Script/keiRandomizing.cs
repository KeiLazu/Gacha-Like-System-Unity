using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class keiRandomizing : MonoBehaviour {

    System.Random keiRandomizer = new System.Random();

    public void keiRandomize()
    {
        GameObject keiGacha = Instantiate(GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.GetComponent<keiGetList>().keiImageList[keiRandomizer.Next(0, 7)].gameObject,
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.transform);

        Debug.Log(keiGacha.name);


    }

}

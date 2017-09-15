/// <summary>
/// keiRandomizing V 1.1
/// Kei Lazu
/// 
/// Display Random output
/// 
/// Changelog:
/// - 1.1 no more instantiating, only pooling object (enable-disable gameobject)
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class keiRandomizing : MonoBehaviour {

    System.Random keiRandomizer = new System.Random();

    Transform keiGetkeiPanelGacha;

    public void keiRandomize()
    {
        //GameObject keiGacha = Instantiate(GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.GetComponent<keiGetList>().keiImageList[keiRandomizer.Next(0, 6)].gameObject,
        //    GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.transform);

        //Debug.Log(keiGacha.name);

        keiGetkeiPanelGacha = GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.transform;

        for (int i = 0; i < keiGetkeiPanelGacha.childCount; i++)
        {
            keiGetkeiPanelGacha.GetChild(i).gameObject.SetActive(false);

        }

        switch (keiRandomizer.Next(0, GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.GetComponent<keiGetList>().keiImageList.Count))
        {
            case 0:
                keiGetkeiPanelGacha.GetChild(0).gameObject.SetActive(true);
                break;

            case 1:
                keiGetkeiPanelGacha.GetChild(1).gameObject.SetActive(true);
                break;

            case 2:
                keiGetkeiPanelGacha.GetChild(2).gameObject.SetActive(true);
                break;

            case 3:
                keiGetkeiPanelGacha.GetChild(3).gameObject.SetActive(true);
                break;

            case 4:
                keiGetkeiPanelGacha.GetChild(4).gameObject.SetActive(true);
                break;

            case 5:
                keiGetkeiPanelGacha.GetChild(5).gameObject.SetActive(true);
                break;

            default:
                break;
        }

    }

}

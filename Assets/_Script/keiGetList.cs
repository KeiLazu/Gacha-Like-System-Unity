using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keiGetList : MonoBehaviour
{
    public List<Image> keiImageList = new List<Image>();

    private void Awake()
    {
        try
        {
            keiImageList.Clear();

            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageBlack);
            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageBlue);
            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageGreen);
            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageRed);
            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageWhite);
            keiImageList.Add(this.gameObject.GetComponent<keiGatherResources>().keiImageYellow);

        }
        catch (System.Exception e)
        {
            Debug.Log(e);

            throw;
        }

    }
}
/// <summary>
/// keiGetList V 1.1
/// Kei Lazu
/// 
/// input all gathered resource into 1 single list
/// 
/// changelog:
/// - 1.1 more optimized using for and more like shorter line of codes
/// 
/// </summary>

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

        for (int i = 0; i < keiImageList.Count; i++)
        {
            keiInstantiator(i);

        }

    }

    public void keiInstantiator(int TargetFromImageList)
    {
        Image keiImage = Instantiate(keiImageList[TargetFromImageList], gameObject.transform);

        switch (TargetFromImageList)
        {
            case 0:
                keiImage.name = "keiImageBlack";
                break;

            case 1:
                keiImage.name = "keiImageBlue";
                break;

            case 2:
                keiImage.name = "keiImageGreen";
                break;

            case 3:
                keiImage.name = "keiImageRed";
                break;

            case 4:
                keiImage.name = "keiImageWhite";
                break;

            case 5:
                keiImage.name = "keiImageYellow";
                break;

            default:
                keiImage.name = "(none)";
                break;
        }

        keiImage.gameObject.SetActive(false);

    }

}
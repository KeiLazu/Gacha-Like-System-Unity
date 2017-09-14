using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keiGatherResources : MonoBehaviour
{
    public Image keiImageBlack, keiImageBlue, keiImageGreen, keiImageRed, keiImageWhite, keiImageYellow;

    private void Awake()
    {
        keiImageBlack = Resources.Load<Image>("Prefabs/keiImgBlack");
        keiImageBlue = Resources.Load<Image>("Prefabs/keiImgBlue");
        keiImageGreen = Resources.Load<Image>("Prefabs/keiImgGreen");
        keiImageRed = Resources.Load<Image>("Prefabs/keiImgRed");
        keiImageWhite = Resources.Load<Image>("Prefabs/keiImgWhite");
        keiImageYellow = Resources.Load<Image>("Prefabs/keiImgYellow");

    }
}
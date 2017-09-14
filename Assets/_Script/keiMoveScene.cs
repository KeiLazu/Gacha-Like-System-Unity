using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keiMoveScene : MonoBehaviour {

    AsyncOperation keiASyncOperation;

    public void keiMoveToTargetScene(int _TargetScene)
    {
        StartCoroutine(keiLoadingController(_TargetScene));

    }

    IEnumerator keiLoadingController(int _TargetScene)
    {
        yield return new WaitForSeconds(1);

        keiASyncOperation = SceneManager.LoadSceneAsync(_TargetScene);
        keiASyncOperation.allowSceneActivation = false;

        while (!keiASyncOperation.isDone)
        {
            if (keiASyncOperation.progress == 0.9f)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    keiASyncOperation.allowSceneActivation = true;

                }

            }

            yield return null;

        }

    }

}

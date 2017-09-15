using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keiScrollController : MonoBehaviour {

    public float keiScrollingSpeed = -15f;

    private void Update()
    {
        keiScrollingSpeed = Mathf.MoveTowards(keiScrollingSpeed, 0, 3f * Time.deltaTime);

        gameObject.transform.Translate(new Vector2(keiScrollingSpeed, 0) * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(Vector2.down, Vector2.up);

        if (hit.collider != null)
        {
            //Debug.Log(hit.collider.gameObject.name);

            while (gameObject.transform.parent.GetChild(0).GetComponent<keiScrollController>().keiScrollingSpeed == 0)
            {
                Debug.Log(hit.collider.gameObject.name);
                break;

            }

        }

    }

}

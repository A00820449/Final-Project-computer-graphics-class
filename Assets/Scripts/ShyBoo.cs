using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShyBoo : MonoBehaviour
{
    GameObject normalFace;
    GameObject shyFace;
    GameObject normalBody;
    GameObject shyBody;
    Hover hoverComponent;
    TurnAround marioScript;
    // Start is called before the first frame update
    void Start()
    {
        normalFace = this.transform.Find("Facial1__TeresaBodyMat00").gameObject;
        shyFace = this.transform.Find("Facial2__TeresaBodyMat00").gameObject;
        normalBody = this.transform.Find("Teresa__TeresaBodyMat00").gameObject;
        shyBody = this.transform.Find("TeresaShay__TeresaBodyMat00").gameObject;
        hoverComponent = GetComponent<Hover>();
        marioScript = GameObject.FindWithTag("Player").GetComponent<TurnAround>();
    }

    // Update is called once per frame
    void Update()
    {
        // Turn on shy model if Mario is turned around
        if (marioScript.TURNED_AROUND)
        {
            goShy();
        }
        else
        {
            goNormal();
        }
    }
    void goShy()
    {
        // Enable the Shy model parts
        shyFace.SetActive(true);
        shyBody.SetActive(true);

        // Disable the normal model parts
        normalFace.SetActive(false);
        normalBody.SetActive(false);

        // Stop the hovering
        hoverComponent.ENABLED = false;
    }
    void goNormal()
    {
        // Disable the shy model parts
        shyFace.SetActive(false);
        shyBody.SetActive(false);

        // Enable the normal model parts
        normalFace.SetActive(true);
        normalBody.SetActive(true);

        // Resume hovering
        hoverComponent.ENABLED = true;
    }
}

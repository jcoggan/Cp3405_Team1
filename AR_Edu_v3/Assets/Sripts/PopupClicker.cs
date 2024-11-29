using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupClicker : MonoBehaviour
{

    public GameObject sunPopup;
    public GameObject mercuryPopup;
    public GameObject venusPopup;
    public GameObject earthPopup;
    public GameObject marsPopup;
    public GameObject jupiterPopup;
    public GameObject saturnPopup;
    public GameObject uranusPopup;
    public GameObject neptunePopup;

    // Spawn Perameters

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressed button");
            // Debug.Log(Input.mousePosition);



            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);

                // if (hit.transform.tag == "sun")
                // {
                //     Vector3 pos = hit.point;
                //     pos.z += 0.25f;
                //     pos.y += 0.25f;
                //     Instantiate(sunPopup, pos, transform.rotation);
                //     sunPopup.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
                // }

                 if (hit.transform.tag == "mercury")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(mercuryPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "venus")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(venusPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "earth")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(earthPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "mars")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(marsPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "jupiter")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(jupiterPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "saturn")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(saturnPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "uranus")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(uranusPopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "neptune")
                {
                    // Vector3 pos = hit.point;
                    // pos.z += 0.25f;
                    // pos.y += 0.25f;
                    Vector3 pos = new Vector3(0f, -1f, 0f);
                    Instantiate(neptunePopup, pos, transform.rotation);
                }

                 if (hit.transform.tag == "info")
                {
                    Destroy(hit.transform.gameObject);
                }

            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;

public class PopupTuch : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();

    // private PlayerInput playerInput;
    // private InputAction touchPressAction;
    // private InputAction touchPositionAction;
    private ARSessionOrigin arSessionOrigin;
    private Camera arCamera;
    public GameObject moonPopup;
    

    // Start is called before the first frame update
    void Start()
    {
        // touchPositionAction = InputSystem.actions.FindAction("ClickPosition");
        // touchPressAction = InputSystem.actions.FindAction("Click");
        arCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(touchPressAction.ReadValue<float>());
    if (Input.touchCount == 0)
        return;
    Debug.Log("1");
    RaycastHit hit;
    Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

    if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("Yessssss");
        }
    }
    //     if (Physics.Raycast(ray, out hit))
    //     {
    //         Debug.Log("hit");
    //         Debug.Log(hit.transform.name + " : " + hit.transform);
    //         if (hit.transform.tag == "sun")
    //         {                    
    //             Vector3 pos = hit.point;
    //             pos.z += 0.25f;
    //             pos.y += 0.25f;
    //             Instantiate(moonPopup, pos, transform.rotation);
    //         }
    //     }    
    // }
    }

    // On click

    // private void Awake()
    // {
    //     touchPositionAction = InputSystem.actions.FindAction("ClickPosition");
    //     touchPressAction = InputSystem.actions.FindAction("Click");
    // }

    // private void OnEnable()
    // {
    //     touchPressAction.Enable();
    //     touchPressAction.performed += TouchPressed;
    // }

    // private void OnDisable()
    // {
        
    //     touchPressAction.performed -= TouchPressed;
    //     touchPressAction.Disable();

    // }

    // private void TouchPressed(InputAction.CallbackContext context)
    // {
    //     Debug.Log("Yess");
    //     // if (context.performed)
    //     // {
            
    //     // Ray ray = Camera.main.ScreenPointToRay(touchPositionAction.ReadValue<Vector3>());
    //     // RaycastHit hit;

    //     // if (Physics.Raycast(ray, out hit, 100))
    //     // {
    //     //     if (hit.transform.tag == "sun")
    //     //     {                    
    //     //         Vector3 pos = hit.point;
    //     //         pos.z += 0.25f;
    //     //         pos.y += 0.25f;
    //     //         Instantiate(moonPopup, pos, transform.rotation);
    //     //     }
    //     // }
    //     // }
    // }
}

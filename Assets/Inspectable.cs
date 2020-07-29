using Lean.Touch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Inspectable : MonoBehaviour
{
    [SerializeField] GameObject DocumentUI;
    //[SerializeField] FirstPersonController fpc;
    //public LayerMask IgnoreMe;

    

    public bool inInspectMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<LeanSelectable>().IsSelected)
        {
            DocumentUI.SetActive(true);
            gameObject.GetComponent<LeanSelectable>().IsSelected = false;
        }






        //if (Input.GetKeyDown(KeyCode.V) && !inInspectMode)
        //{
        //    inInspectMode = true;
        //    Debug.Log("Inspect mode On *********************************************");

        //}
        //else if (Input.GetKeyDown(KeyCode.V) && inInspectMode)
        //{
        //    inInspectMode = false;
        //}


        //if (inInspectMode)
        //{
        //    fpc.enabled = false;
        //    Cursor.lockState = CursorLockMode.None;

        //    Cursor.visible = true;

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        Debug.Log("Mouse is down");

        //        RaycastHit hitInfo = new RaycastHit();
        //        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, 1000f, ~IgnoreMe);
        //        if (hit)
        //        {
        //            Debug.Log("Hit " + hitInfo.transform.gameObject.name);
        //            if (hitInfo.transform.gameObject.tag == "Inspectable")
        //            {
        //                Debug.Log("It's working!");
        //                DocumentUI.SetActive(true);
        //            }
        //            else
        //            {
        //                Debug.Log("nopz");
        //            }
        //        }
        //        else
        //        {
        //            Debug.Log("No hit");
        //        }
        //        Debug.Log("Mouse is down");
        //    }

        //}
        //else
        //{
        //    Cursor.lockState = CursorLockMode.Locked;
        //    Cursor.visible = false;
        //    fpc.enabled = true;
           

        //}

    }

  

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Modal : MonoBehaviour
{
    // Start is called before the first frame update
    public Image modalImage;
    private bool modalisActive = false; //메뉴 엑티브를 위한 Flag
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ModalActive();
    }

    void ModalActive()
    {
        if (Input.GetKeyDown("q"))
        {
            modalisActive = !modalisActive;
            modalImage.gameObject.SetActive(modalisActive);

        }
    }

    public IEnumerator modal()
    {
        yield return new WaitUntil(() => Input.GetKey(KeyCode.Q));
         modalisActive = !modalisActive;
            modalImage.gameObject.SetActive(modalisActive);
    }
}

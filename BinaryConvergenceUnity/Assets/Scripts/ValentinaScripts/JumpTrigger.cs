using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerCam;
    public GameObject JumpCam;

    private void OnTriggerEnter(Collider other)
    {
        JumpCam.SetActive(true);
        PlayerCam.SetActive(false);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        PlayerCam.SetActive(true);
        JumpCam.SetActive(false);
    }
}

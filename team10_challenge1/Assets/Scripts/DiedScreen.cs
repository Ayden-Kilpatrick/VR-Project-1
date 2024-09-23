using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        JumpScareImg.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            JumpScareImg.SetActive(true);
            audioSource.Play();
            StartCoroutine(DisableImg());
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(10);
        JumpScareImg.SetActive(false);
    }

}
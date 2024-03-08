using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _do, _re;

    // Start is called before the first frame update
    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent <AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.D)) {
            _do.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _re.Play();
        }
    }
}

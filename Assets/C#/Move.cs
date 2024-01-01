using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody>();
        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), 3 , PlayerPrefs.GetFloat("z"));  //تحفظ اخر مكان وصل له االاعب 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //AudioSource.PlayOneShot(clip"clip");
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(horizontal, 0, vertical);

        Rigidbody.MovePosition(Rigidbody.position + Movement * 3 * Time.fixedDeltaTime);
        soundManager.PlayPllayerJump();

    }

    void LateUpdate()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("z", transform.position.z);
        //تحفظ اخر مكان وصل له االاعب 
    
    }
   
}

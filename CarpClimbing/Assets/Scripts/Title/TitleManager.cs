using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class TitleManager : MonoBehaviour
{
    Animator anim;
    public float moveSpeed = 0.5f;
    public void PushStartButton()
    {
        //Bool�^�̃p�����[�^�[�ł���AnimationSwitch��True�ɂ���
      //  anim.SetBool("AnimationSwitch", true);
        SceneManager.LoadScene("GameScene");
    }
    // Start is called before the first frame update
    void Start()
    {
       // anim = GetComponent<Animator>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

            //Bool�^�̃p�����[�^�[�ł���blRot��True�ɂ���
            
        
    }
}

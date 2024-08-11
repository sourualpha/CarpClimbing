using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class TitleManager : MonoBehaviour
{
    Animator anim;
    AudioSource audioSource;

    [SerializeField]
    AudioClip SE;
    [SerializeField]
    GameObject BackGround;
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
       // anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        BackGround.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

            
        
    } 
    
    public void PushStartButton()
    {
        //Bool型のパラメーターであるAnimationSwitchをTrueにする
        //  anim.SetBool("AnimationSwitch", true);
        BackGround.SetActive(true);
        audioSource.PlayOneShot(SE);
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameScene");

    }
}

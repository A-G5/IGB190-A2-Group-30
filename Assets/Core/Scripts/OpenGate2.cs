using UnityEngine;

public class OpenGate2 : MonoBehaviour
{
    public GameObject gate;
    public bool canOpen2 = false;
    private Animator openGate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openGate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        canOpen2 = LogicEngine.GetGlobalVariable<bool>("CanOpenGate2");

        if (canOpen2 == true)
        {
            openGate.Play("Gate Open");
        }
    }


}

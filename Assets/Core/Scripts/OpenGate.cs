using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public GameObject gate;
    public bool canOpen = false;
    private Animator openGate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openGate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        canOpen = LogicEngine.GetGlobalVariable<bool>("CanOpenGate1");

        if (canOpen == true)
        {
            openGate.Play("Gate Open");
        }
    }


}

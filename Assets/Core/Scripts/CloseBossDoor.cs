using UnityEngine;

public class CloseBossDoor : MonoBehaviour
{
    public GameObject gate;
    public bool canClose = false;
    private Animator closeGate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        closeGate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        canClose = LogicEngine.GetGlobalVariable<bool>("CanCloseBossGate");

        if (canClose == true)
        {
            closeGate.Play("Gate Closed");
        }
    }


}

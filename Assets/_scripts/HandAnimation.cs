using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripActionReference;

    [SerializeField] private InputActionReference triggerActionReferece;

    private Animator animator;


    private string gripActionName = "Grip";
    private string triggeeActionName = "pinch";


    private void Awake()
    {
        animator = GetComponent<Animator>();

        if (!animator)
        {
            Debug.LogError("Animator is Null");
        }
    }

    private void Update()
    {
        if (animator == null)
        {
            return;
        }
        float gripValue = gripActionReference.action.ReadValue<float>();
        float triggerValue = triggerActionReferece.action.ReadValue<float>();



        animator.SetFloat(gripActionName, gripValue);
        animator.SetFloat(triggeeActionName, triggerValue);


    }

}

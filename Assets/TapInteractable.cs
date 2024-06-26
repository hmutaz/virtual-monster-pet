using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class TapInteractable : ARBaseGestureInteractable
{
    [SerializeField] private Animator mAnimator;
    [SerializeField] private AudioSource mAud;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    public override bool IsSelectableBy(IXRSelectInteractor interactor) => interactor is ARGestureInteractor;

    protected override bool CanStartManipulationForGesture(TapGesture gesture) => true;

    protected override void OnEndManipulation(TapGesture gesture)
    {
        base.OnEndManipulation(gesture);

        if (gesture.isCanceled)
            return;
        if (gestureInteractor == null)
            return;

        if (gesture.targetObject == gameObject)
        {
            if (mAnimator != null)
            {
                mAnimator.Play("Tapped", 0);
                mAud.Play();
            }
        }
    }
}

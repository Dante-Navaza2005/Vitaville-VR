using EasyTransition;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load_scene : MonoBehaviour
{
    // Start is called before the first frame update
    public TransitionSettings transition;
    public float loadDelay;
    public string scene_name;

    public void load_transition()
    {
        TransitionManager.Instance().Transition(scene_name, transition, loadDelay);
    }
}

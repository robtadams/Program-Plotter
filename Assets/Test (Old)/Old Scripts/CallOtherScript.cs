using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CallOtherScript : MonoBehaviour {
  // Assign by dragging the GameObject with ScriptA into the inspector before running the game.
  public OtherScript m_someOtherScriptOnAnotherGameObject;
 
  void Start() {
    m_someOtherScriptOnAnotherGameObject.Test();
  }
}
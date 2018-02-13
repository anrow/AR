using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxDestroySelf : MonoBehaviour {
    private void Awake( ) {
        Destroy( this.gameObject, 1f );
    }
}

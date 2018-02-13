using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearPanel : MonoBehaviour {
    private void Update( ) {

        if( FindObjectOfType<EnemyManager>( ).IsClear( ) ) { 
            Debug.Log( "result" );
            Invoke( "SetResult", 1.5f );
        }
    }
    void SetResult( ) {
        GameManager.Instance.SetResultPanel( );
    }
}

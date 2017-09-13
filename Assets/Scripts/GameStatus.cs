using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour {

    static GameStatus instance;

    public static GameStatus GetInstance( ) {
        return instance;
    }

    void Start( ) {

        instance = this;

        GameObject.DontDestroyOnLoad( this.gameObject );

        if( instance != null ) {
            Destroy( this.gameObject );
            return;
        }

    }

    void OnDestroy( ) {
        Debug.Log( "GameStatus was destroyed!!" );
    }

    public void LoadScene( string sceneName ) {
        SceneManager.LoadScene( sceneName );
    }

}

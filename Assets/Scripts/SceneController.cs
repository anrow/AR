using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneController {

    public static void MoveScenes( List<string> sceneNames ) {

        List<string> activeSceneNames = GetActiveSceneNames( );

        Dictionary<string, bool> activeSceneNameMap = activeSceneNames.ToDictionary( name => name, name => true );

        Dictionary<string, bool> sceneNameMap = sceneNames.ToDictionary( name => name, name => true );

        foreach( string sceneName in sceneNames ) {

            if( !activeSceneNameMap.ContainsKey( sceneName ) ) {

                SceneManager.LoadScene( sceneName, LoadSceneMode.Additive );

            }
        }

        foreach( string activeSceneName in activeSceneNames ) {

            if( !sceneNameMap.ContainsKey( activeSceneName ) ) {

                SceneManager.UnloadSceneAsync( activeSceneName );

            }

        }

    }

	public static List<string> GetActiveSceneNames( ) {

        int sceneCount = SceneManager.sceneCount;

        List<string> activeSceneNames = new List<string>( );

        for( int i = 0; i < sceneCount; i++ ) {
            Scene scene = SceneManager.GetSceneAt( i );
            activeSceneNames.Add( scene.name );
        }

        return activeSceneNames;
    }
}

using UnityEngine;
using System;
using System.Collections;

public class SoundManager : MonoBehaviour {

	private static SoundManager instance;

	public static SoundManager Instance {
		get {
			if( instance == null ) {
				
				instance = ( SoundManager ) FindObjectOfType( typeof( SoundManager ) );

				if( instance == null ) {
					Debug.LogError("SoundManager Instance Error");
				}
			}
			return instance;
		}
	}

	/*[SerializeField]
	private Sound[ ] m_Sounds; 
	*/

	// === AudioSource ===
	// BGM
    [SerializeField]
	private AudioSource m_BgmSource;
	// SE
    [SerializeField]
	private AudioSource m_SeSource;

	// === AudioClip ===
	// BGM
    [SerializeField]
	private AudioClip[ ] m_Bgm;
	// SE
    [SerializeField]
	private AudioClip[ ] m_Se;

	void Awake( ){
		// 全てのAudioSourceコンポーネントを追加する

		// BGM AudioSource
		m_BgmSource = gameObject.AddComponent<AudioSource>( );
		// BGMはループを有効にする
		m_BgmSource.loop = true;

		// SE AudioSource
		m_SeSource = gameObject.AddComponent<AudioSource>( );

	}
	
	// ***** BGM再生 *****
	// BGM再生
	public void PlayBGM( int index ){
		if( 0 > index || m_Bgm.Length <= index ){
			return;
		}
		// 同じBGMの場合は何もしない
		if( m_BgmSource.clip == m_Bgm[ index ] ){
			return;
		}
		
		m_BgmSource.clip = m_Bgm[ index ];
		m_BgmSource.Play( );
	}

	// BGM停止
	public void StopBGM( bool _SwitchOn ){
		m_BgmSource.volume = _SwitchOn ? 0 : 1; 
	}

	// ***** SE再生 *****
	// SE再生
	public void PlaySE( int index ) {
		if( 0 > index || m_Se.Length <= index ){
			return;
		}
		m_SeSource.clip = m_Se[ index ];
		m_SeSource.Play( );
	}

	// SE停止
	public void StopSE( bool _SwitchOn ){
		m_SeSource.volume = _SwitchOn ? 0 : 1;
	}

}


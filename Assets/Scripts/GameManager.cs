﻿using UnityEngine;
using System.Collections;

    
    public class GameManager : MonoBehaviour
    {

        public static GameManager instance = null;

		/* Pelin tilat
		 * 1 = peli alkamassa
		 * 2 = peli käynnissä
		 * 3 = peli keskeytetty (pause)
		 * 4 = peli loppu (game over, peli hävitty, elämät loppu)
		 * 5 = peli/kenttä voitettu (munakupit täytetty)
		 */
		public int gameState;

        //Awake is always called before any Start functions
        void Awake()
        {
            //Check if instance already exists
            if (instance == null)
                
                //if not, set instance to this
                instance = this;
            
            //If instance already exists and it's not this:
            else if (instance != this)
                
                //Then destroy this. This enforces our singleton pattern, 
				//meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);    
            
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
        }

}

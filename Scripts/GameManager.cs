using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        [SerializeField] public GameObject activePlayer;
        public GameObject playerPrefab;
        public bool isPlaying;

        public UnityAction OnGameOverAction;
        public MyScriptableInteger life;
        public MyScriptableInteger coin;
        public MyEnemySpawner spawner;

        public List<GameObject> items;



        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static GameManager GetInstance()
        {
            return instance;
        }

        void Start()
        {
            SpawnPlayer();
        }
        private void SpawnPlayer()
        {
            activePlayer = Instantiate(playerPrefab);
        }

        public Vector3 getPlayerPosition()
        {
            if (activePlayer != null)
            {
                return activePlayer.transform.position;
            }
            return Vector3.zero;
        }

        public void startGame()
        {
            isPlaying = true;
            SpawnPlayer();
        }

        public void resumeGame()
        {
            isPlaying = true;
            Time.timeScale = 1;
        }

        public void pauseGame()
        {
            isPlaying = false;
            Time.timeScale = 0;
        }

        internal void gameOver()
        {
            isPlaying = false;
            OnGameOverAction?.Invoke();
        }
        internal void retry()
        {
            life.reset();
            coin.reset();
            spawner.clearEnemies();
            MyObjectPool.GetInstance().deactivateAllObject();
            clearAllItem();
        }

        internal void addItem(GameObject gameObject)
        {
            items.Add(gameObject);
        }

        public void clearAllItem()
        {
            foreach (GameObject go in items)
            {
                Destroy(go);
            }
            items.Clear();
        }
    }

}
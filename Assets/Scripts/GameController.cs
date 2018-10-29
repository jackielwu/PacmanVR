using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text score;
    public Text lives;
    private bool gameOver;
    public int _score;
    public int _lives;
    public bool energized;
    private bool win;
    public GameObject winner;
    public GameObject go;

    void Start () {
        gameOver = false;
        _score = 0;
        _lives = 3;
        energized = false;
        win = false;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] pacdots = GameObject.FindGameObjectsWithTag("PacDot");
        if (pacdots.Length == 0)
        {
            win = true;
        }
        if (_lives == 0)
            gameOver = true;
		
	}

    private void OnGUI()
    {
        score.text = _score.ToString();

        lives.text = _lives.ToString();
        if (gameOver)
        {
            Time.timeScale = 0;
            //GUI.Label(new Rect(200, 200, 100, 20), "Game Over");
            go.SetActive(true);
        }
        
        if (win)
        {
            Time.timeScale = 0;
            winner.SetActive(true);
        }
        
        
    }

    void Energize()
    {
        /*
        GameObject[] ghosts = GameObject.FindObjectsOfType<Sprite>();
        foreach (GameObject g in ghosts)
        {
            g.GetComponent<SpriteRenderer>().sprite = (Sprite) Resources.Load("Sprites/scared");
        }
        */
    }
}

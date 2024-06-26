namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }
        /// <summary>
        /// 次に切り替えたい状態
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// 現在の状態
        /// </summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitSate();
            UpdateState();
            UpdateGame();
        }
        void InitSate()
        {
            if (nextState == State.None)
            {
                return;
            }
            currentState = nextState;
            nextState = State.None;

            //初期化処理 lam cho no sang len
            switch (currentState)
            {
                case State.Title:
                    lableTitle.Visible = false;
                    buttonStart.Visible = false;
                    break;

                case State.Game:
                    lableTitle.Visible = false;
                    buttonStart.Visible = false;
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }
        void UpdateGame()
        {

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
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
        /// éüÇ…êÿÇËë÷Ç¶ÇΩÇ¢èÛë‘
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// åªç›ÇÃèÛë‘
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

            //èâä˙âªèàóù lam cho no sang len
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
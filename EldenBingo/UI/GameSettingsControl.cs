using Newtonsoft.Json.Linq;
using ObidoBingoCommon;

namespace ObidoBingo.UI
{
    public partial class GameSettingsControl : UserControl
    {
        public GameSettingsControl()
        {
            InitializeComponent();
            _randomSeedUpDown.ValueChanged += (o, e) => SeedChanged?.Invoke();
        }

        public int CurrentSeed => Convert.ToInt32(_randomSeedUpDown.Value);

        private int BoardSize
        {
            get { return _boardSizeComboBox.SelectedIndex + 3; }
            set { _boardSizeComboBox.SelectedIndex = value - 3; }
        }

        public bool RequiredSquares
        {
            get { return _requiredSquares.Checked; }
            set { _requiredSquares.Checked = value; }
        }

        public Action? SeedChanged;

        public BingoGameSettings Settings
        {
            get
            {
                return new BingoGameSettings(
                    BoardSize,
                    Convert.ToInt32(_maxCategoryUpDown.Value),//Max number of squares in the same category
                    Convert.ToInt32(_randomSeedUpDown.Value), //Random seed
                    Convert.ToInt32(_preparationTimeUpDown.Value), //Preparation time in seconds
                    Convert.ToInt32(_bonusPointsUpDown.Value), //Bonus points for a bingo line
                    RequiredSquares
                );
            }
            set
            {
                BoardSize = value.BoardSize;
                _maxCategoryUpDown.Value = value.CategoryLimit;
                _randomSeedUpDown.Value = value.RandomSeed;
                _preparationTimeUpDown.Value = value.PreparationTime;
                _bonusPointsUpDown.Value = value.PointsPerBingoLine;
                _requiredSquares.Checked = value.RequiredSquares;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _randomSeedUpDown.Value = 0;
        }
    }
}
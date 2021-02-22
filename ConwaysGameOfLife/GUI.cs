using GameOfLife;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    public partial class GUI : Form
    {
        Board board;
        DateTime _lastCheckTime;
        long _frameCount;
        
        public GUI()
        {
            InitializeComponent();
            Reset();
        }

        ///<summary>
        ///Resets the board.
        ///</summary>
        private void Reset()
        {
            board = new Board(pictureBox1.Width, pictureBox1.Height, (int)cellSizeButton.Value, WrapCellsCheckbox.Checked);
            _lastCheckTime = DateTime.Now;
            _frameCount = 0;
            board.Genocide();
            Render();
        }

        ///<summary>
        ///Resets the board and initialises it with a starting pattern.
        ///</summary>
        public void Reset(string startingPattern)
        {
            Reset();
            if (PatternInsideBoundries(startingPattern)) {
                string[] lines = startingPattern.Split('\n');
                int yOffset = (board.Rows - lines.Length) / 2;
                int xOffset = (board.Columns - lines[0].Length) / 2;

                for (int y = 0; y < lines.Length; y++)
                    for (int x = 0; x < lines[y].Length; x++)
                        board.Cells[x + xOffset, y + yOffset].isAlive = lines[y].Substring(x, 1) == "X";
            }
            Render();
        }

        ///<summary>
        ///Renders the board to a pictureBox.
        ///</summary>
        private void Render()
        {
            var bitmap = new Bitmap(board.Width, board.Height);
            var graphics = Graphics.FromImage(bitmap);
            var brush = new SolidBrush(Color.LightSkyBlue);
            graphics.Clear(Color.Black);

            int cellSize = board.CellSize > 2 ? board.CellSize - 1 : board.CellSize;


            for (int column = 0; column < board.Columns; column++)
            {
                for (int row = 0; row < board.Rows; row++)
                {
                    var cell = board.Cells[column, row];
                    if (cell.isAlive)
                    {
                        var location = new Point(column * board.CellSize, row * board.CellSize);
                        var rect = new Rectangle(location, new Size(cellSize, cellSize));
                        graphics.FillRectangle(brush, rect);
                    }
                }
            }

            pictureBox1.Image = (Bitmap)bitmap.Clone();
            Interlocked.Increment(ref _frameCount);
        }

        ///<summary>
        ///Reads a pattern from an input .txt file.
        ///</summary>
        private string ReadPattern(string filename)
        {
            string path = "..\\..\\Patterns\\" + filename + ".txt";
            return System.IO.File.ReadAllText(path);
        }

        ///<summary>
        ///Checks if the pattern would go out of bounds on the picture box. 
        ///Returns true if pattern goes out of bounds.
        ///</summary>
        private bool PatternInsideBoundries(string pattern)
        {
            string[] lines = pattern.Split('\n');
            var longestLineLength = lines.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length;
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;
            if (longestLineLength + xOffset >= board.Columns || lines.GetLength(0) + yOffset >= board.Rows)
                return false;
            else
                return true;
        }

        ///<summary>
        ///Calculates the frames per second.
        ///</summary>
        double GetFps()
        {
            double secondsElapsed = (DateTime.Now - _lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref _frameCount, 0);
            double fps = count / secondsElapsed;
            _lastCheckTime = DateTime.Now;
            return fps;
        }

        // Event managers
        private void CellSizeButton_ValueChanged(object sender, EventArgs e) { Reset(); }
        
        private void WrapCellsCheckbox_CheckedChanged(object sender, EventArgs e) { Reset(); }
        
        private void PictureBox1_SizeChanged(object sender, EventArgs e) { Reset(); }
        
        private void TimerSpeedTrackBar_Scroll(object sender, EventArgs e) { timer1.Interval = TimerSpeedTrackBar.Value; }
        
        private void GunButton_Click(object sender, EventArgs e) { Reset(ReadPattern("gliderGun")); }
        
        private void SpaceshipButton_Click(object sender, EventArgs e) { Reset(ReadPattern("Spaceship")); }
        
        private void ComplexRowButton_Click(object sender, EventArgs e) { Reset(ReadPattern("complexRow")); }
        
        private void GliderButton_Click(object sender, EventArgs e) { Reset(ReadPattern("glider")); }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            board.NextStep();
            Render();
        }

        private void ManualInputBox_TextChanged(object sender, EventArgs e)
        {
            string input = ManualInputBox.Text;
            if (PatternInsideBoundries(input))
                Reset(input);
            else
                Reset();
        }
        
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Reset();
            board.RandomPattern();
        }
        
        private void Timer2_Tick(object sender, EventArgs e)
        {
            string fps = Math.Round(GetFps()).ToString();
            float aliveCells = board.AliveCells();
            float percentAlive = aliveCells == 0 ? 0 : (float)Math.Round((aliveCells) / (board.Rows * board.Columns) * 100, 2);
            this.Text = "Game of Life | " + fps + " fps | " + aliveCells.ToString() + " cells alive" + " (" + percentAlive.ToString() + "%)";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

/*
 * Name:Linlin Fan
 * Date:August 17, 2017
 * StudentID:300923300
 * Description:The ScoreBoard class of Pick Highest Card Application.
 * Version:0.1 
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        public TextBox FinalScoreTextBox
        {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                this.FinalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                this.Score = PickHighestCardForm.ScoreTextBox.Text;
            }
        }
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                this.Time = value;
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return _time;
            }
            set
            {
                this.Time = value;
            }
        }
    }
}

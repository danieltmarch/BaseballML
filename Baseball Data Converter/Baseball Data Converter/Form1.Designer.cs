namespace Baseball_Data_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "game id",
            "visiting team",
            "inning",
            "batting team",
            "outs",
            "balls",
            "strikes",
            "pitch sequence",
            "vis score",
            "home score",
            "batter",
            "batter hand",
            "res batter",
            "res batter hand",
            "pitcher",
            "pitcher hand",
            "res pitcher",
            "res pitcher hand",
            "catcher",
            "first base",
            "second base",
            "third base",
            "shortstop",
            "left field",
            "center field",
            "right field",
            "first runner",
            "second runner",
            "third runner",
            "event text",
            "leadoff flag",
            "pinchhit flag",
            "defensive position",
            "lineup position",
            "event type",
            "batter event flag",
            "ab flag",
            "hit value",
            "SH flag",
            "SF flag",
            "outs on play",
            "double play flag",
            "triple play flag",
            "RBI on play",
            "wild pitch flag",
            "passed ball flag",
            "fielded by",
            "batted ball type",
            "bunt flag",
            "foul flag",
            "hit location",
            "num errors",
            "1st error player",
            "1st error type",
            "2nd error player",
            "2nd error type",
            "3rd error player",
            "3rd error type",
            "batter dest (5 if scores and unearned, 6 if team unearned)",
            "runner on 1st dest (5 if scores and unearned, 6 if team unearned)",
            "runner on 2nd dest (5 if scores and unearned, 6 if team unearned)",
            "runner on 3rd dest (5 if socres and uneanred, 6 if team unearned)",
            "play on batter",
            "play on runner on 1st",
            "play on runner on 2nd",
            "play on runner on 3rd",
            "SB for runner on 1st flag",
            "SB for runner on 2nd flag",
            "SB for runner on 3rd flag",
            "CS for runner on 1st flag",
            "CS for runner on 2nd flag",
            "CS for runner on 3rd flag",
            "PO for runner on 1st flag",
            "PO for runner on 2nd flag",
            "PO for runner on 3rd flag",
            "Responsible pitcher for runner on 1st",
            "Responsible pitcher for runner on 2nd",
            "Responsible pitcher for runner on 3rd",
            "New Game Flag",
            "End Game Flag",
            "Pinch-runner on 1st",
            "Pinch-runner on 2nd",
            "Pinch-runner on 3rd",
            "Runner removed for pinch-runner on 1st",
            "Runner removed for pinch-runner on 2nd",
            "Runner removed for pinch-runner on 3rd",
            "Batter removed for pinch-hitter",
            "Position of batter removed for pinch-hitter",
            "Fielder with First Putout (0 if none)",
            "Fielder with Second Putout (0 if none)",
            "Fielder with Third Putout (0 if none)",
            "Fielder with First Assist (0 if none)",
            "Fielder with Second Assist (0 if none)",
            "Fielder with Third Assist (0 if none)",
            "Fielder with Fourth Assist (0 if none)",
            "Fielder with Fifth Assist (0 if none)",
            "Event num"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 92);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 574);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

